using EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class PersonDAO
    {
        private DbConnection dbConn = new DbConnection();

        public void Add(Person person, string tableName)
        {
            string sqlCmd = string.Format("INSERT INTO {0}(PersonID, Name, Gender, BirthDate, Telephone, Email, Location, Password) VALUES ({1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})",
                tableName, person.PersonID, person.Name, (person.Gender == true ? "Male" : "Female"), person.BirthDate, person.Telephone, person.Email, person.Location, person.Password);
            dbConn.Execute(sqlCmd);
        }
    }
}
