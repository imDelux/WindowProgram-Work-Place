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
                resultPerson.Age = int.Parse(reader["Age"].ToString());
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
                resultPerson.Age = int.Parse(reader["Age"].ToString());
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
            string skillCategory;
            string skillName;
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
                skillCategory = reader["SkillCategory"].ToString();
                skillName = reader["SkillName"].ToString();
                skillDescription = reader["SkillDescription"].ToString();
                skillExpectedWage = int.Parse(reader["ExpectedWage"].ToString(), CultureInfo.InvariantCulture.NumberFormat);

                result.Add(new Skill(skillCategory, skillName, skillDescription, skillExpectedWage));
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
            string personID, fname, tel, email, location;
            int age;

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
                age = int.Parse(reader["Age"].ToString());
                tel = reader["Telephone"].ToString();
                email = reader["Email"].ToString();
                location = reader["Location"].ToString();

                list.Add(new Person(personID, fname, age, tel, email, location, string.Empty));
            }

            // Close connection
            conn.Close();

            return list;
        }

        /// <summary>
        /// Fetch worker list base on skill category
        /// </summary>
        /// <returns></returns>
        public List<Person> FetchWorkerList(string cat)
        {
            // Result storage
            List<Person> list = new List<Person>();

            // Store information of each worker
            string personID, fname, tel, email, location;
            int age;

            // Connect to database
            conn.Open();

            // Initialize SQL command
            string strCmd = string.Format("SELECT w.PersonID, Name, Age, Telephone, Email, Location FROM Worker w, Skills s WHERE w.PersonID = s.PersonID AND s.SkillCategory = 'cat'");
            SqlCommand cmd = new SqlCommand(strCmd, conn);

            // Read data
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                personID = reader["PersonID"].ToString();
                fname = reader["Name"].ToString();
                age = int.Parse(reader["Age"].ToString());
                tel = reader["Telephone"].ToString();
                email = reader["Email"].ToString();
                location = reader["Location"].ToString();

                list.Add(new Person(personID, fname, age, tel, email, location, string.Empty));
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
            bool isMorning, isAccept, isReject, isComplete, isEvaluate, isPaid, isRead;

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

                isMorning = (reader["IsMorning"].ToString() == "True" ? true : false);
                isAccept = (reader["IsAccepted"].ToString() == "True" ? true : false);
                isReject = (reader["IsRejected"].ToString() == "True" ? true : false);
                isComplete = (reader["IsComplete"].ToString() == "True" ? true : false);
                isEvaluate = (reader["IsEvaluated"].ToString() == "True" ? true : false);
                isPaid = (reader["IsPaid"].ToString() == "True" ? true : false);
                isRead = (reader["IsRead"].ToString() == "True" ? true : false);

                result.Add(new Job(jobID, workerID, hirerID, jobName, jobDescription, jobDate, wage, isMorning, isAccept, isReject, isComplete, isEvaluate, isPaid, isRead));
            }

            // Close connection and return
            conn.Close();
            return result;
        }

        /// <summary>
        /// Fetch skill category
        /// </summary>
        /// <returns></returns>
        public List<CategorySkill> FetchSkillCategory()
        {
            // Result
            List<CategorySkill> result = new List<CategorySkill>();
            CategorySkill categorySkill = new CategorySkill();

            // Open connection
            conn.Open();

            // Initialize SQL command to get skill category
            string strCmdCat = string.Format("SELECT * FROM SkillCategory");
            SqlCommand sqlCommandCat = new SqlCommand(strCmdCat, conn);

            // Read category
            SqlDataReader readerCat = sqlCommandCat.ExecuteReader();
            while (readerCat.Read())
            {
                categorySkill = new CategorySkill();
                categorySkill.CategoryName = readerCat["Category"].ToString();
                categorySkill.NumbWorker = int.Parse(readerCat["NumbWorker"].ToString());

                result.Add(categorySkill);
            }

            // Close connection and return
            conn.Close();
            return result;
        }

        /// <summary>
        /// Fill skill in each category
        /// </summary>
        /// <param name="categorySkill"></param>
        /// <returns></returns>
        public void FillSkill(List<CategorySkill> categorySkill)
        {
            // Open
            conn.Open();

            // Initialize
            string strCmd = string.Format("SELECT * FROM SkillList");
            SqlCommand sqlCommand = new SqlCommand(strCmd, conn);

            // Read
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read())
            {
                string skillCate = reader["SkillCategory"].ToString();
                string skillName = reader["SkillName"].ToString();

                foreach (CategorySkill cat in categorySkill)
                {
                    if (cat.CategoryName == skillCate)
                    {
                        cat.SkillList.Add(skillName);
                        break;
                    }
                }
            }

            // Close & Return
            conn.Close();
        }
    }
}
