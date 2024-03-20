using EntityModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// Get worker data in database
        /// </summary>
        /// <returns>A list of worker in database</returns>
        public List<Worker> getWorkerList()
        {
            // Result storage
            List<Worker> list = new List<Worker>();

            // Connect to database
            conn.Open();

            // Initialize SQL command
            string strCmd = "SELECT * FROM Worker";
            SqlCommand cmd = new SqlCommand(strCmd, conn);

            // Read data
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string personID, fname, tel, email, location, password;
                bool gender;
                DateTime birth;

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
