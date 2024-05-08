using EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class WorkerDAO : PersonDAO
    {
        DbConnection dbConn = new DbConnection();

        /// <summary>
        /// Fetch basic information base on email and password of a worker
        /// </summary>
        /// <param name="person">This object only has password and email</param>
        /// <returns>Person need, if not appear return null</returns>
        public Worker FetchBasicInformation(Person person)
        {
            string sqlCmd = string.Format("SELECT * FROM Worker WHERE Email = '{0}' AND Password = '{1}'", person.Email, person.Password);
            return dbConn.FetchWorker(sqlCmd);
        }

        public string Add(Worker worker)
        {
            string strCmd = string.Format("INSERT INTO Worker(PersonID, Name, Age, Telephone, Email, Location, Password, IsActive) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                worker.PersonID, worker.Name, worker.Age, worker.Telephone, worker.Email, worker.Location, worker.Password, false);
            return dbConn.Execute(strCmd);
        }

        public string UpdateSkill(Worker worker)
        {
            string strCmd = string.Format("UPDATE Worker SET SkillName = '{0}', SkillDescription = '{1}', SkillType = '{2}', ExpectedWage = '{3}' WHERE PersonID = '{4}'",
                worker.SkillName, worker.SkillDescription, worker.SkillType, worker.ExpectedWage.ToString(), worker.PersonID);
            return dbConn.Execute(strCmd);
        }

        public string SwitchActiveMode(Worker worker)
        {
            string strCmd = string.Format("UPDATE Worker SET IsActive = '{0}' WHERE PersonID = '{1}'",
                worker.IsActive, worker.PersonID);
            return dbConn.Execute(strCmd);
        }
    }
}
