using EntityModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAO
{
    public class DbConnection
    {
        private SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);

        /// <summary>
        /// Execute a SQL command
        /// </summary>
        /// <param name="sqlStr">SQL command</param>
        /// <returns>Result message. If success: "Successful", otherwise return error message.</returns>
        public string Execute(string sqlStr)
        {
            string result = "";
            try
            {
                // Connect to database
                conn.Open();

                // Initialize SQl command
                SqlCommand cmd = new SqlCommand(sqlStr, conn);

                // Execute
                if (cmd.ExecuteNonQuery() > 0)
                {
                    result = "Successful";
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();

            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        /// <summary>
        /// Fetch data about A PERSON
        /// </summary>
        /// <param name="sqlCommand">SQL command</param>
        /// <returns>Person need, if not appear return null</returns>
        public Person FetchPerson(string sqlCommand)
        {
            // Store result
            Person resultPerson = new Person();

            // Connect to database
            conn.Open();

            // Initialize SQL command
            SqlCommand cmd = new SqlCommand(sqlCommand, conn);

            // Read data
            SqlDataReader reader = cmd.ExecuteReader();

            // If no row found
            if (!reader.HasRows)
            {
                resultPerson = null;
            }
            else
            {
                reader.Read();
                resultPerson.PersonID = reader["PersonID"].ToString();
                resultPerson.Name = reader["Name"].ToString();
                resultPerson.Gender = reader["Gender"].ToString() == "Male" ? true : false;
                if (DateTime.TryParse(reader["BirthDate"].ToString(), out DateTime resultBirth) == true)
                {
                    resultPerson.BirthDate = resultBirth;
                }
                resultPerson.Telephone = reader["Telephone"].ToString();
                resultPerson.Email = reader["Email"].ToString();
                resultPerson.Location = reader["Location"].ToString();
            }

            // Disconnect to database
            conn.Close();

            // Return result
            return resultPerson;
        }

        /// <summary>
        /// Fetch a skill list of a person (worker) from database
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <returns>Skill need, otherwise return null</returns>
        public List<Skill> FetchSkill(string sqlCommand)
        {
            // Store result
            List<Skill> result = new List<Skill>();

            // Store information of each skill
            SkillName skill;
            int skillExpectedWage;
            string skillDescription;

            // Connet to database
            conn.Open();

            // Initialize SQL command
            SqlCommand cmd = new SqlCommand(sqlCommand, conn);

            // Read data
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Try parse the skill name first
                if (Enum.TryParse(reader["SkillName"].ToString(), out SkillName skillName) == true)
                {
                    skill = skillName;
                }
                else
                {
                    skill = SkillName.None;
                }
                skillDescription = reader["SkillDescription"].ToString();
                skillExpectedWage = int.Parse(reader["ExpectedWage"].ToString(), CultureInfo.InvariantCulture.NumberFormat);

                result.Add(new Skill(skill, skillDescription, skillExpectedWage));
            }

            // Disconnect from database
            conn.Close();

            // Return result
            return result;
        }

        /// <summary>
        /// Get worker data in database
        /// </summary>
        /// <returns>A list of worker in database</returns>
        public List<Worker> getWorkerList()
        {
            // Result storage
            List<Worker> list = new List<Worker>();
            
            // Store information of each worker
            string personID, fname, tel, email, location, password;
            bool gender;
            DateTime birth;

            // Connect to database
            conn.Open();

            // Initialize SQL command
            string strCmd = "SELECT * FROM Worker";
            SqlCommand cmd = new SqlCommand(strCmd, conn);

            // Read data
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                personID = reader["PersonID"].ToString();
                fname = reader["Name"].ToString();
                gender = reader["Gender"].ToString() == "Male" ? true : false;
                if (DateTime.TryParse(reader["BirthDate"].ToString(), out birth) == false)
                {
                    birth = DateTime.Now;
                }
                tel = reader["Telephone"].ToString();
                email = reader["Email"].ToString();
                location = reader["Location"].ToString();
                password = reader["Password"].ToString();

                list.Add(new Worker(personID, fname, gender, birth, tel, email, location, password, new List<Skill> { }));
            }

            // Close connection
            conn.Close();

            return list;
        }
    }
}
