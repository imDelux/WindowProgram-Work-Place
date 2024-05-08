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

        public string Add(Job nJob)
        {
            string strCmd = string.Format("INSERT INTO Job(JobID, HirerID, WorkerID , JobName, JobDescription, Date, Wage, IsMorning, IsAccepted, IsRejected, IsComplete, IsCanceled, IsEvaluated, IsWorkerRated, IsRead) " +
                "VALUES (NEWID(), '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}')",
                nJob.HirerID, nJob.WorkerID, nJob.JobName, nJob.JobDescription, nJob.Date, nJob.Wage, nJob.IsMorning, nJob.IsAccepted, nJob.IsRejected, nJob.IsComplete, nJob.IsCanceled, nJob.IsEvaluated, nJob.IsWorkerRated, nJob.IsRead);
            return dbConn.Execute(strCmd);
        }

        /// <summary>
        /// Update a job in case the worker accept the job
        /// </summary>
        /// <param name="nJob"></param>
        public void Update_Accept(Job nJob) 
        {
            string strCmd = string.Format("UPDATE Job SET IsAccepted = 'True' WHERE JobID = '{0}'", nJob.JobID);
            dbConn.Execute(strCmd);
        }

        /// <summary>
        /// Update a job in case the worker reject the job
        /// </summary>
        /// <param name="nJob"></param>
        public void Update_Reject(Job nJob)
        {
            string strCmd = string.Format("UPDATE Job SET IsRejected = 'True' WHERE JobID = '{0}'", nJob.JobID);
            dbConn.Execute(strCmd);
        }

        /// <summary>
        /// Update a job in case the job is completed
        /// </summary>
        /// <param name="nJob"></param>
        public void Update_Complete(Job nJob)
        {
            string strCmd = string.Format("UPDATE Job SET IsComplete = 'True' WHERE JobID = '{0}'", nJob.JobID);
            dbConn.Execute(strCmd);
        }

        /// <summary>
        /// Update a job in case the job is canceled
        /// </summary>
        /// <param name="nJob"></param>
        public void Update_Cancel(Job nJob)
        {
            string strCmd = string.Format("UPDATE Job SET IsCanceled = 'True' WHERE JobID = '{0}'", nJob.JobID);
            dbConn.Execute(strCmd);
        }

        /// <summary>
        /// Update a job when the worker read the job message
        /// </summary>
        /// <param name="nJob"></param>
        public void Update_Read(Job nJob)
        {
            string strCmd = string.Format("UPDATE Job SET IsRead = 'True' WHERE JobID = '{0}'", nJob.JobID);
            dbConn.Execute(strCmd);
        }

        /// <summary>
        /// Update a job when the job is evaluated
        /// </summary>
        /// <param name="nJob"></param>
        public void Update_Evaluate (Job nJob)
        {
            string strCmd = string.Format("UPDATE Job SET IsEvaluated = 'True' WHERE JobID = '{0}'", nJob.JobID);
            dbConn.Execute(strCmd);
        }

        /// <summary>
        /// Update a job when the job is evaluated by worker
        /// </summary>
        /// <param name="nJob"></param>
        public void Update_WorkerRate(Job nJob)
        {
            string strCmd = string.Format("UPDATE Job SET IsWorkerRated = 'True' WHERE JobID = '{0}'", nJob.JobID);
            dbConn.Execute(strCmd);
        }
    }
}