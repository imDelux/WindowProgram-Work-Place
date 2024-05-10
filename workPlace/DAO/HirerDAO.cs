using EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HirerDAO : PersonDAO
    {
        DbConnection dbConnection = new DbConnection();
        public string AddFavoriteWorker(Person hirer, Worker worker)
        {
            string sqlCmd = string.Format("INSERT INTO FavoriteWorker(HirerID, WorkerID) VALUES ('{0}', '{1}')",
                hirer.PersonID, worker.PersonID);
            return dbConnection.Execute(sqlCmd);
        }

        public string DeleteFavoriteWorker(Person hirer, Worker worker)
        {
            string strCmd = string.Format("DELETE FROM FavoriteWorker WHERE HirerID = '{0}' AND WorkerID = '{1}'", hirer.PersonID, worker.PersonID);
            return dbConnection.Execute(strCmd);
        }
    }
}
