using EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class JobDAO
    {
        DbConnection dbConn = new DbConnection();

        public void Add(Job nJob)
        {
            string sqlCmd = string.Format("INSERT INTO Job(JobID, HirerID, WorkerID , JobName, JobDescription, Date, Wage, JobStatus, Paid, Accept) " +
                "VALUES (NEWID(), '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                nJob.HirerID, nJob.WorkerID, nJob.JobName, nJob.JobDescription, nJob.Date, nJob.Wage, nJob.JobStatus, nJob.PaidStatus, nJob.Accept);
            dbConn.Execute(sqlCmd);
        }
    }
}
