using EntityModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
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
                resultPerson.Password = reader["Password"].ToString();
            }

            // Disconnect to database
            conn.Close();

            // Return result
            return resultPerson;
        }

        /// <summary>
        /// Fet A WORKER based on command
        /// </summary>
        /// <param name="strCmd"></param>
        /// <returns></returns>
        public Worker FetchWorker(string strCmd)
        {
            // Store result
            Worker resultWorker = new Worker();

            // Connect to database
            conn.Open();

            // Initialize SQL command
            SqlCommand cmd = new SqlCommand(strCmd, conn);

            // Read data
            SqlDataReader reader = cmd.ExecuteReader();

            // If no row found
            if (!reader.HasRows)
            {
                resultWorker = null;
            }
            else
            {
                reader.Read();
                resultWorker.PersonID = reader["PersonID"].ToString();
                resultWorker.Name = reader["Name"].ToString();
                resultWorker.Age = int.Parse(reader["Age"].ToString());
                resultWorker.Telephone = reader["Telephone"].ToString();
                resultWorker.Email = reader["Email"].ToString();
                resultWorker.Location = reader["Location"].ToString();
                resultWorker.Password = reader["Password"].ToString();
                resultWorker.IsActive = reader["IsActive"].ToString() == "True";
                resultWorker.SkillName = reader["SkillName"].ToString();
                resultWorker.SkillDescription = reader["SkillDescription"].ToString();
                resultWorker.SkillType = reader["SkillType"].ToString();
                if (!int.TryParse(reader["ExpectedWage"].ToString(), out int expectedWage))
                {
                    expectedWage = 0;
                }
                resultWorker.ExpectedWage = expectedWage;
            }

            // Disconnect to database
            conn.Close();

            // Return result
            return resultWorker;
        }

        /// <summary>
        /// Fetch person base on person id
        /// </summary>
        /// <param name="personID"></param>
        /// <returns></returns>
        public Worker FetchWorker_ID(string personID)
        {
            // Store result
            Worker resultWorker = new Worker();

            // Connect to database
            conn.Open();

            // Initialize SQL command
            string strCmd = string.Format("SELECT * FROM Worker WHERE PersonID = '{0}'", personID);
            SqlCommand cmd = new SqlCommand(strCmd, conn);

            // Read data
            SqlDataReader reader = cmd.ExecuteReader();

            // If no row found
            if (!reader.HasRows)
            {
                resultWorker = null;
            }
            else
            {
                reader.Read();
                resultWorker.PersonID = reader["PersonID"].ToString();
                resultWorker.Name = reader["Name"].ToString();
                resultWorker.Age = int.Parse(reader["Age"].ToString());
                resultWorker.Telephone = reader["Telephone"].ToString();
                resultWorker.Email = reader["Email"].ToString();
                resultWorker.Location = reader["Location"].ToString();
                resultWorker.Password = reader["Password"].ToString();
                resultWorker.IsActive = reader["IsActive"].ToString() == "True";
                resultWorker.SkillName = reader["SkillName"].ToString();
                resultWorker.SkillDescription = reader["SkillDescription"].ToString();
                resultWorker.SkillType = reader["SkillType"].ToString();
                resultWorker.ExpectedWage = int.Parse(reader["ExpectedWage"].ToString());
            }

            // Disconnect to database
            conn.Close();

            // Return result
            return resultWorker;
        }

        /// <summary>
        /// Fetch person base on person id
        /// </summary>
        /// <param name="personID"></param>
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
                resultPerson.Password = reader["Password"].ToString();
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
                isActive = reader["IsActive"].ToString() == "True";
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
        /// Fetch worker list based on category
        /// </summary>
        /// <returns></returns>
        public List<Worker> FetchWorkerList(CategorySkill categorySkill)
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
            string strCmd = string.Format("SELECT * FROM Worker WHERE SkillType = '{0}'", categorySkill.Id);
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
                isActive = reader["IsActive"].ToString() == "True";
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
        /// Fetch a job by job id
        /// </summary>
        /// <param name="person"></param>
        /// <param name="isWorker">Check if person is worker or not</param>
        /// <returns></returns>
        public Job FetchJob_ID(string jID)
        {
            // Result storage
            Job result = new Job();

            // Connect to database
            conn.Open();

            // Initialize SQL command
            string strCMD = string.Format("SELECT * FROM Job WHERE JobID = '{0}'", jID);
            SqlCommand sqlCommand = new SqlCommand(strCMD, conn);

            // Read data
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                result.JobID = reader["JobID"].ToString();
                result.HirerID = reader["HirerID"].ToString();
                result.WorkerID = reader["WorkerID"].ToString();
                result.JobName = reader["JobName"].ToString();
                result.JobDescription = reader["JobDescription"].ToString();
                if (DateTime.TryParse(reader["Date"].ToString(), out DateTime jobDate) == false)
                {
                    jobDate = DateTime.Now;
                }
                else
                {
                    result.Date = jobDate;
                }
                result.Wage = int.Parse(reader["Wage"].ToString());

                result.IsMorning = reader["IsMorning"].ToString() == "True";
                result.IsAccepted = reader["IsAccepted"].ToString() == "True";
                result.IsRejected = reader["IsRejected"].ToString() == "True";
                result.IsComplete = reader["IsComplete"].ToString() == "True";
                result.IsCanceled = reader["IsCanceled"].ToString() == "True";
                result.IsEvaluated = reader["IsEvaluated"].ToString() == "True";
                result.IsWorkerRated = reader["IsWorkerRated"].ToString() == "True";
                result.IsRead = reader["IsRead"].ToString() == "True";
            }

            // Close connection and return
            conn.Close();
            return result;
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
            bool isMorning, isAccept, isReject, isComplete, isCanceled, isEvaluate, isWorkerRated, isRead;

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

                isMorning = reader["IsMorning"].ToString() == "True";
                isAccept = reader["IsAccepted"].ToString() == "True";
                isReject = reader["IsRejected"].ToString() == "True";
                isComplete = reader["IsComplete"].ToString() == "True";
                isCanceled = reader["IsCanceled"].ToString() == "True";
                isEvaluate = reader["IsEvaluated"].ToString() == "True";
                isWorkerRated = reader["IsWorkerRated"].ToString() == "True";
                isRead = reader["IsRead"].ToString() == "True";

                result.Add(new Job(jobID, workerID, hirerID, jobName, jobDescription, jobDate, wage, isMorning, isAccept, isReject, isComplete, isCanceled, isEvaluate, isWorkerRated, isRead));
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

                result.Add(categorySkill);
            }

            // Close connection and return
            conn.Close();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="WorkerID"></param>
        /// <returns></returns>
        public List<Evaluate> FetchEvaluateOfAWorker(string WorkerID)
        {
            List<Evaluate> result = new List<Evaluate>();
            string jID, commenterID, comment;
            bool isWorker;
            float point;

            conn.Open();

            // SQL initialize
            string strCmd = string.Format("SELECT e.JobID, CommenterID, IsWorker, Point, Comment " +
                "FROM Evaluate e, Job j " +
                "WHERE e.JobID = j.JobID AND IsWorker = 0 AND j.WorkerID = '{0}'", WorkerID);
            SqlCommand sqlCmd = new SqlCommand(strCmd, conn);

            // Read
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                jID = reader["JobID"].ToString();
                commenterID = reader["CommenterID"].ToString();
                isWorker = reader["IsWorker"].ToString() == "True";
                point = float.Parse(reader["Point"].ToString());
                comment = reader["Comment"].ToString();

                result.Add(new Evaluate(jID, commenterID, isWorker, point, comment));
            }

            conn.Close();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="WorkerID"></param>
        /// <returns></returns>
        public List<Evaluate> FetchEvaluateOfAHirer(string HirerID)
        {
            List<Evaluate> result = new List<Evaluate>();
            string jID, commenterID, comment;
            bool isWorker;
            float point;

            conn.Open();

            // SQL initialize
            string strCmd = string.Format("SELECT e.JobID, CommenterID, IsWorker, Point, Comment " +
                "FROM Evaluate e, Job j " +
                "WHERE e.JobID = j.JobID AND IsWorker = 1 AND j.HirerID = '{0}'", HirerID);
            SqlCommand sqlCmd = new SqlCommand(strCmd, conn);

            // Read
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                jID = reader["JobID"].ToString();
                commenterID = reader["CommenterID"].ToString();
                isWorker = reader["IsWorker"].ToString() == "True";
                point = float.Parse(reader["Point"].ToString());
                comment = reader["Comment"].ToString();

                result.Add(new Evaluate(jID, commenterID, isWorker, point, comment));
            }

            conn.Close();
            return result;
        }

        public List<Evaluate> FetchCanceledJobOfAWorker(string workerID)
        {
            List<Evaluate> result = new List<Evaluate>();
            string jID, commenterID, comment;
            bool isWorker;
            float point;

            conn.Open();

            // SQL initialize
            string strCmd = string.Format("SELECT e.JobID, CommenterID, IsWorker, Point, Comment " +
                "FROM Evaluate e, Job j " +
                "WHERE e.JobID = j.JobID AND IsWorker = 0 AND j.WorkerID = '{0}' AND IsCanceled = 1", workerID);
            SqlCommand sqlCmd = new SqlCommand(strCmd, conn);

            // Read
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                jID = reader["JobID"].ToString();
                commenterID = reader["CommenterID"].ToString();
                isWorker = reader["IsWorker"].ToString() == "True";
                point = float.Parse(reader["Point"].ToString());
                comment = reader["Comment"].ToString();

                result.Add(new Evaluate(jID, commenterID, isWorker, point, comment));
            }

            conn.Close();
            return result;
        }

        /// <summary>
        /// Get post list that a hirer post
        /// </summary>
        /// <param name="hirerID"></param>
        /// <returns></returns>
        public List<Post> FetchPostListOfAHirer(string hirerID)
        {
            List<Post> result = new List<Post>();
            string id, hireID, title, description, skillType;
            DateTime date;
            bool isMorning;
            int wage;

            conn.Open();

            // SQL initialize
            string strCMD = string.Format("SELECT * FROM Post WHERE HirerID = '{0}'", hirerID);
            SqlCommand sqlCmd = new SqlCommand(strCMD, conn);

            // Read
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader["ID"].ToString();
                hireID = reader["HirerID"].ToString();
                title = reader["Title"].ToString();
                description = reader["Description"].ToString();
                date = DateTime.Parse(reader["Date"].ToString());
                isMorning = reader["IsMorning"].ToString() == "True";
                skillType = reader["SkillType"].ToString();
                wage = int.Parse(reader["Wage"].ToString());

                result.Add(new Post(id, hirerID, title, description, date, isMorning, skillType, wage));
            }


            conn.Close();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public List<Post> FetchPostOfACategory(CategorySkill category)
        {
            List<Post> result = new List<Post>();
            string id, hirerID, title, description, skillType;
            DateTime date;
            bool isMorning;
            int wage;

            conn.Open();

            // SQL initialize
            string strCMD = string.Format("SELECT * FROM Post WHERE SkillType = '{0}'", category.Type);
            SqlCommand sqlCmd = new SqlCommand(strCMD, conn);

            // Read
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader["ID"].ToString();
                hirerID = reader["HirerID"].ToString();
                title = reader["Title"].ToString();
                description = reader["Description"].ToString();
                date = DateTime.Parse(reader["Date"].ToString());
                isMorning = reader["IsMorning"].ToString() == "True";
                skillType = reader["SkillType"].ToString();
                wage = int.Parse(reader["Wage"].ToString());

                result.Add(new Post(id, hirerID, title, description, date, isMorning, skillType, wage));
            }


            conn.Close();
            return result;
        }

        /// <summary>
        /// Get worker list that apply into a post
        /// </summary>
        /// <param name="postID"></param>
        /// <returns></returns>
        public List<Worker> FetchApplyWorker(string postID)
        {
            List<Worker> result = new List<Worker>();
            conn.Open();

            string strCmd = string.Format("SELECT * FROM Apply WHERE PostID = '{0}'", postID);
            SqlCommand sqlCmd = new SqlCommand(strCmd, conn);

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while(reader.Read())
            {
                Worker worker = new Worker();
                worker.PersonID = reader["WorkerID"].ToString();
                result.Add(worker);
            }

            conn.Close();

            for (int i = 0; i < result.Count; i++)
            {
                result[i] = FetchWorker_ID(result[i].PersonID);
            }

            return result;
        }
    }
}
