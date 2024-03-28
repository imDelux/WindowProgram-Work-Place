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
        /// Fetch person base on command
        /// </summary>
        /// <param name="strCmd"></param>
        /// <returns></returns>
        public Person FetchPerson(string strCmd)
        {
            // Store result
            Person resultPerson = new Person();

            // Connect to database
            conn.Open();

            // Initialize SQL command
            SqlCommand cmd = new SqlCommand(strCmd, conn);

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
        /// Fetch person base on person id
        /// </summary>
        /// <param name="personID"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public Person FetchPerson(string personID, string table)
        {
            // Store result
            Person resultPerson = new Person();

            // Connect to database
            conn.Open();

            // Initialize SQL command
            string strCmd = string.Format("SELECT * FROM {0} WHERE PersonID = '{1}'", table, personID);
            SqlCommand cmd = new SqlCommand(strCmd, conn);

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
        public List<Skill> FetchSkillList(string personID)
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
            string sqlCommand = string.Format("SELECT * FROM Skills WHERE PersonID = '{0}'", personID);
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
        public List<Person> FetchWorkerList()
        {
            // Result storage
            List<Person> list = new List<Person>();
            
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

                list.Add(new Person(personID, fname, gender, birth, tel, email, location, password));
            }

            // Close connection
            conn.Close();

            return list;
        }

        /// <summary>
        /// Fetch a job list equivalent to a specific person
        /// </summary>
        /// <param name="person"></param>
        /// <param name="isWorker">Check if person is worker or not</param>
        /// <returns></returns>
        public List<Job> FetchJobList(Person person, bool isWorker)
        {
            // Result storage
            List<Job> result = new List<Job>();
            string jobID, hirerID, workerID, jobName, jobDescription;
            DateTime jobDate;
            int wage;
            bool jobStatus, isPaid, isAccepted;

            // Connect to database
            conn.Open();

            // Initialize SQL command
            string collumn = (isWorker ? "WorkerID" : "HirerID");
            string strCMD = string.Format("SELECT * FROM Job WHERE {0} = '{1}'", collumn, person.PersonID);
            SqlCommand sqlCommand = new SqlCommand(strCMD, conn);

            // Read data
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read())
            {
                jobID = reader["JobID"].ToString();
                hirerID = reader["HirerID"].ToString();
                workerID = reader["WorkerID"].ToString();
                jobName = reader["JobName"].ToString();
                jobDescription = reader["JobDescription"].ToString();
                if (DateTime.TryParse(reader["Date"].ToString(), out jobDate) == false)
                {
                    jobDate = DateTime.Now;
                }
                wage = int.Parse(reader["Wage"].ToString());
                jobStatus = (reader["JobStatus"].ToString() == "True" ? true : false);
                isPaid = (reader["Paid"].ToString() == "True" ? true : false);
                isAccepted = (reader["Accept"].ToString() == "True" ? true : false);

                result.Add(new Job(jobID, workerID, hirerID, jobName, jobDescription, jobDate, wage, jobStatus, isPaid, isAccepted));
            }

            // Close connection and return
            conn.Close();
            return result;
        }
    }
}
