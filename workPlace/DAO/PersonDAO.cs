using EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace DAO
{
    public class PersonDAO
    {
        private DbConnection dbConn = new DbConnection();

        /// <summary>
        /// Fetch basic information base on email and password of a person
        /// </summary>
        /// <param name="person">This object only has password and email</param>
        /// <returns>Person need, if not appear return null</returns>
        public Person FetchBasicInformation(Person person, string tableName)
        {
            string sqlCmd = string.Format("SELECT * FROM {0} WHERE Email = '{1}' AND Password = '{2}'", tableName, person.Email, person.Password);
            return dbConn.FetchPerson(sqlCmd);
        }

        public string Add(Person person, string tableName)
        {
            string sqlCmd = string.Format("INSERT INTO {0}(PersonID, Name, Age, Telephone, Email, Location, Password) VALUES ('{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                tableName, person.PersonID, person.Name, person.Age, person.Telephone, person.Email, person.Location, person.Password);
            return dbConn.Execute(sqlCmd);
        }

        public Image LoadAvatar(Person person)
        {
            Image result = null;

            // Display avatar
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"Avatars\", @"avt_" + person.PersonID + @".jpeg")))
            {
                result = new Bitmap(Path.Combine(Environment.CurrentDirectory, @"Avatars\", @"avt_" + person.PersonID + @".jpeg"));
            }
            else if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"Avatars\", @"avt_" + person.PersonID + @".jpg")))
            {
                result = new Bitmap(Path.Combine(Environment.CurrentDirectory, @"Avatars\", @"avt_" + person.PersonID + @".jpg"));
            }
            else if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"Avatars\", @"avt_" + person.PersonID + @".gif")))
            {
                result = new Bitmap(Path.Combine(Environment.CurrentDirectory, @"Avatars\", @"avt_" + person.PersonID + @".gif"));
            }
            else if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"Avatars\", @"avt_" + person.PersonID + @".bmp")))
            {
                result = new Bitmap(Path.Combine(Environment.CurrentDirectory, @"Avatars\", @"avt_" + person.PersonID + @".bmp"));
            }

            return result;
        }
    }
}
