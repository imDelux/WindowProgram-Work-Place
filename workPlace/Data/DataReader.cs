using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataReader
    {
        private SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

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
                string personID, fname, tel, email, location;
                bool gender;
                DateTime birth;

                personID = reader["PersonID"].ToString();
                fname = reader["Name"].ToString();
                gender = reader["Gender"].ToString() == "Male" ? true : false;
                if (DateTime.TryParse(reader["BirthDate"].ToString(),out birth) == false)
                {
                    birth = DateTime.Now;
                }
                tel = reader["Telephone"].ToString();
                email = reader["Email"].ToString();
                location = reader["Location"].ToString();

                list.Add(new Worker(personID, fname, gender, birth, tel, email, location, new List<Skill> { }));
            }

            // Close connection
            conn.Close();

            return list;
        }
    }
}
