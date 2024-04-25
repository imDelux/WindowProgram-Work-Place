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
            string strCmd = string.Format("INSERT INTO Job(JobID, HirerID, WorkerID , JobName, JobDescription, Date, Wage, IsMorning, IsAccepted, IsRejected, IsComplete, IsEvaluated, IsPaid) " +
                "VALUES (NEWID(), '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')",
                nJob.HirerID, nJob.WorkerID, nJob.JobName, nJob.JobDescription, nJob.Date, nJob.Wage, nJob.IsMorning, nJob.IsAccepted, nJob.IsRejected, nJob.IsComplete, nJob.IsEvaluated, nJob.IsPaid);
            dbConn.Execute(strCmd);
        }

        public void Delete(Job nJob) { }

        /// <summary>
        /// Update a job in case the hirer accept the job
        /// </summary>
        /// <param name="nJob"></param>
        public void Update_Accept(Job nJob) 
        {
            string strCmd = string.Format("UPDATE Job SET IsAccepted = 'True' WHERE JobID = '{0}'", nJob.JobID);
            dbConn.Execute(strCmd);
        }
    }
}