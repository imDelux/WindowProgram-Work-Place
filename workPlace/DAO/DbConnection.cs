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
        /// Get worker data in database
        /// </summary>
        /// <returns>A list of worker in database</returns>
        public List<Worker> FetchWorkerList()
        {
            // Result storage
            List<Worker> list = new List<Worker>();
            
            // Store information of each worker
            string personID, fname, tel, email, location, skillName, skillDescription, skillType;
            bool isActive;
            int age, expectedWage;

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
                isActive = (reader["IsActive"].ToString() == "True" ? true : false);
                skillName = reader["SkillName"].ToString();
                skillDescription = reader["SkillDescription"].ToString();
                skillType = reader["SkillType"].ToString();
                expectedWage = int.Parse(reader["ExpectedWage"].ToString());

                list.Add(new Worker(personID, fname, age, tel, email, location, string.Empty, isActive, skillName, skillDescription, skillType, expectedWage));
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
            string strCmdCat = string.Format("SELECT * FROM SkillTypeList");
            SqlCommand sqlCommandCat = new SqlCommand(strCmdCat, conn);

            // Read category
            SqlDataReader readerCat = sqlCommandCat.ExecuteReader();
            while (readerCat.Read())
            {
                categorySkill = new CategorySkill();
                categorySkill.Id = readerCat["Id"].ToString();
                categorySkill.Type = readerCat["Type"].ToString();
                categorySkill.NumbWorker = int.Parse(readerCat["NumbWorker"].ToString());

                result.Add(categorySkill);
            }

            // Close connection and return
            conn.Close();
            return result;
        }
    }
}
