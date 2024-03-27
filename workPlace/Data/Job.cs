using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class Job
    {
        /// <summary>
        /// Basic attributes about a job
        /// worker --> who work
        /// hirer --> who hiring
        /// jobStatus --> determine if the job is done
        /// paidStatus --> determine if hirer pays worker
        /// </summary>
        private string _id;
        private string _workerID;
        private string _hirerID;
        private string _jobName;
        private string _jobDescription;
        private DateTime _date;
        private float _wage;
        private bool _jobStatus;
        private bool _paidStatus;
        private bool _accept;

        /// <summary>
        /// Properties
        /// </summary>
        public string JobID { get { return _id; } set { _id = value; } }
        public string WorkerID { get { return _workerID; } set { _workerID = value; } }
        public string HirerID { get { return _hirerID; } set { _hirerID = value; } }
        public string JobName { get { return _jobName; } set { _jobName = value; } }
        public string JobDescription { get { return _jobDescription; } set { _jobDescription = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }   
        public float Wage { get { return _wage; } set { _wage = value; } }
        public bool JobStatus { get { return _jobStatus; } set { _jobStatus = value; } }
        public bool PaidStatus { get { return _paidStatus; } set { _paidStatus = value; } }
        public bool Accept { get { return _accept; } set { _accept = value; } }

        /// <summary>
        /// Basic constructor
        /// </summary>
        public Job()
        {
            JobID = string.Empty;
            WorkerID = string.Empty;
            HirerID = string.Empty;
            JobName = string.Empty;
            JobDescription = string.Empty;
            Date = DateTime.MinValue;
            Wage = 0;
            JobStatus = false;
            PaidStatus = false;
            Accept = false;
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="hirer"></param>
        /// <param name="jobName"></param>
        /// <param name="jobDescription"></param>
        /// <param name="date"></param>
        /// <param name="wage"></param>
        /// <param name="jobStatus"></param>
        /// <param name="paidStatus"></param>
        public Job(string jobID, Worker worker, Hirer hirer, string jobName, string jobDescription, DateTime date, float wage, bool jobStatus, bool paidStatus, bool accept)
        {
            JobID = jobID;
            WorkerID = string.Empty;
            HirerID = string.Empty;
            JobName = jobName;
            JobDescription = jobDescription;
            Date = date;
            Wage = wage;
            JobStatus = jobStatus;
            PaidStatus = paidStatus;
            Accept = accept;
        }
    }
}
