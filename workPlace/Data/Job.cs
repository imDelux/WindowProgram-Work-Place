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
        /// </summary>
        private string _id;
        private string _workerID;
        private string _hirerID;
        private string _jobName;
        private string _jobDescription;
        private DateTime _date;
        private float _wage;
        private bool _isMorning;

        // Job flags
        private bool _isAccepted;
        private bool _isRejected;
        private bool _isComplete;
        private bool _isCanceled;
        private bool _isEvaluated;
        private bool _isWorkerRated;
        private bool _isRead;

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
        public bool IsMorning { get { return _isMorning; } set { _isMorning = value; } }
        public bool IsAccepted { get { return _isAccepted; } set { _isAccepted = value; } }
        public bool IsRejected { get { return _isRejected; } set { _isRejected = value; } }
        public bool IsComplete { get { return _isComplete; } set { _isComplete = value; } }
        public bool IsCanceled { get { return _isCanceled; } set { _isCanceled = value; } }
        public bool IsEvaluated { get { return _isEvaluated; } set { _isEvaluated = value; } }
        public bool IsWorkerRated { get { return _isWorkerRated; } set { _isWorkerRated = value; } }
        public bool IsRead { get { return _isRead; } set { _isRead = value; } }

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
            IsMorning = false;
            IsAccepted = false;
            IsRejected = false;
            IsComplete = false;
            IsCanceled = false;
            IsEvaluated = false;
            IsWorkerRated = false;
            IsRead= false;
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
        public Job(string jobID, string workerID, string hirerID, string jobName, string jobDescription, DateTime date, float wage,
            bool isMorning, bool isAccepted, bool isRejected, bool isComplete, bool isCanceled, bool isEvaluated, bool isWorkerRated, bool isRead)
        {
            JobID = jobID;
            WorkerID = workerID;
            HirerID = hirerID;
            JobName = jobName;
            JobDescription = jobDescription;
            Date = date;
            Wage = wage;
            IsMorning = isMorning;
            IsAccepted = isAccepted;
            IsRejected = isRejected;
            IsComplete = isComplete;
            IsCanceled= isCanceled;
            IsEvaluated = isEvaluated;
            IsWorkerRated = isWorkerRated;
            IsRead = isRead;
        }
    }
}
