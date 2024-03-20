using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
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
        private Worker _worker;
        private Hirer _hirer;
        private string _jobName;
        private string _jobDescription;
        private DateTime _date;
        private float _wage;
        private bool _jobStatus;
        private bool _paidStatus;

        /// <summary>
        /// Properties
        /// </summary>
        public string JobID { get { return _id; } set { _id = value; } }
        public Worker Worker { get { return _worker; } set {  _worker = value; } }
        public Hirer Hirer { get { return _hirer; } set { _hirer = value; } }
        public string JobName { get { return _jobName; } set { _jobName = value; } }
        public string JobDescription { get { return _jobDescription; } set { _jobDescription = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }   
        public float Wage { get { return _wage; } set { _wage = value; } }
        public bool JobStatus { get { return _jobStatus; } set { _jobStatus = value; } }
        public bool PaidStatus { get { return _paidStatus; } set { _paidStatus = value; } }

        /// <summary>
        /// Basic constructor
        /// </summary>
        public Job()
        {
            JobID = string.Empty;
            Worker = new Worker();
            Hirer = new Hirer();
            JobName = string.Empty;
            JobDescription = string.Empty;
            Date = DateTime.MinValue;
            Wage = 0;
            JobStatus = false;
            PaidStatus = false;
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
        public Job(string jobID, Worker worker, Hirer hirer, string jobName, string jobDescription, DateTime date, float wage, bool jobStatus, bool paidStatus)
        {
            JobID = jobID;
            Worker = worker;
            Hirer = hirer;
            JobName = jobName;
            JobDescription = jobDescription;
            Date = date;
            Wage = wage;
            JobStatus = jobStatus;
            PaidStatus = paidStatus;
        }
    }
}
