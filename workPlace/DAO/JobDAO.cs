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

        /// <summary>
        /// Get wage of each day in a specific month
        /// </summary>
        /// <param name="monthDate"></param>
        /// <param name="worker"></param>
        /// <returns>List day's wage</returns>
        public List<int> WageOfMonth(DateTime monthDate, Worker worker)
        {
            List<int> result = new List<int>();

            // Filter done job of month
            List<Job> jobListOfWorker = dbConn.FetchJobList(worker, true);
            jobListOfWorker = jobListOfWorker.Where(x => 
            (x.IsComplete 
            && x.IsAccepted 
            && !x.IsCanceled 
            && x.Date.Month == monthDate.Month 
            && x.Date.Year == monthDate.Year)).OrderBy(x => x.Date.Day).ToList();

            // Resize result
            result.Capacity = DateTime.DaysInMonth(monthDate.Year, monthDate.Month);
            for (int i = 0; i < result.Capacity; i++) { result.Add(0); }

            // Fill data into result
            foreach (Job job in jobListOfWorker)
            {
                result[job.Date.Day - 1] += (int)job.Wage;
            }

            return result;
        }

        /// <summary>
        /// Get wage of each month of a specific year
        /// </summary>
        /// <param name="yearDate"></param>
        /// <param name="worker"></param>
        /// <returns>List month's wage</returns>
        public List<int> WageOfYear(DateTime yearDate, Worker worker)
        {
            List<int> result = new List<int>();

            // Filter done job of year
            List<Job> jobListOfWorker = dbConn.FetchJobList(worker, true);
            jobListOfWorker = jobListOfWorker.Where(x =>
            (x.IsComplete
            && x.IsAccepted
            && !x.IsCanceled
            && x.Date.Year == yearDate.Year)).OrderBy(x => x.Date.Day).ToList();

            // Resize result
            for (int i = 0; i < 12; i++) { result.Add(0); }

            // Fill data into result
            foreach (Job job in jobListOfWorker)
            {
                result[job.Date.Month - 1] += (int)job.Wage;
            }

            return result;
        }

        /// <summary>
        /// Get number of job the worker have done in a specific year
        /// </summary>
        /// <param name="yearDate"></param>
        /// <param name="worker"></param>
        /// <returns>Total done job in year</returns>
        public int NumbJobDoneOfYear(DateTime yearDate, Worker worker)
        {
            // Filter done job of year
            List<Job> jobListOfWorker = dbConn.FetchJobList(worker, true);
            jobListOfWorker = jobListOfWorker.Where(x =>
            (x.IsComplete
            && x.IsAccepted
            && !x.IsCanceled
            && x.Date.Year == yearDate.Year)).OrderBy(x => x.Date.Day).ToList();

            return jobListOfWorker.Count;
        }

        /// <summary>
        /// Get number of job the worker have been canceled in a specific year
        /// </summary>
        /// <param name="yearDate"></param>
        /// <param name="worker"></param>
        /// <returns>Total canceled job in year</returns>
        public int NumbJobCancelOfYear(DateTime yearDate, Worker worker)
        {
            // Filter done job of year
            List<Job> jobListOfWorker = dbConn.FetchJobList(worker, true);
            jobListOfWorker = jobListOfWorker.Where(x =>
            (x.IsComplete
            && x.IsAccepted
            && x.IsCanceled
            && x.Date.Year == yearDate.Year)).OrderBy(x => x.Date.Day).ToList();

            return jobListOfWorker.Count;
        }

        /// <summary>
        /// Get number of job the worker have been done in a specific month
        /// </summary>
        /// <param name="monthDate"></param>
        /// <param name="worker"></param>
        /// <returns>Total done job in month</returns>
        public int NumbJobDoneOfMonth(DateTime monthDate, Worker worker)
        {
            // Filter done job of year
            List<Job> jobListOfWorker = dbConn.FetchJobList(worker, true);
            jobListOfWorker = jobListOfWorker.Where(x =>
            (x.IsComplete
            && x.IsAccepted
            && !x.IsCanceled
            && x.Date.Month == monthDate.Month)).OrderBy(x => x.Date.Day).ToList();

            return jobListOfWorker.Count;
        }

        /// <summary>
        /// Get number of job the worker have been canceled in a specific month
        /// </summary>
        /// <param name="monthDate"></param>
        /// <param name="worker"></param>
        /// <returns>Total canceled job</returns>
        public int NumbJobCancelOfMonth(DateTime monthDate, Worker worker)
        {
            // Filter done job of year
            List<Job> jobListOfWorker = dbConn.FetchJobList(worker, true);
            jobListOfWorker = jobListOfWorker.Where(x =>
            (x.IsComplete
            && x.IsAccepted
            && x.IsCanceled
            && x.Date.Month == monthDate.Month)).OrderBy(x => x.Date.Day).ToList();

            return jobListOfWorker.Count;
        }
    }
}