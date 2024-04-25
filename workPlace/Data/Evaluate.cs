using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class Evaluate
    {
        /// <summary>
        /// point is how statisfied the writer feel
        /// comment describe more detail
        /// </summary>
        private string _jobID;
        private string _commenterID;
        private bool _isWorker;
        private float _point;
        private string _comment;

        public string JobID { get { return _jobID; } set { _jobID = value; } }
        public string CommenterID { get { return _commenterID; } set { _commenterID = value; } }
        public bool IsWorker { get { return _isWorker; } set { _isWorker = value; } }
        public float Point { get { return _point; } set { _point = value; } }
        public string Comment { get { return _comment; } set { _comment = value; } }

        /// <summary>
        /// Basic constructor
        /// </summary>
        public Evaluate() 
        {
            JobID = string.Empty;
            CommenterID = string.Empty;
            IsWorker = true;
            Point = 0;
            Comment = string.Empty;
        }

        public Evaluate(string jID, string commenterID, bool isWorker, float point, string comment)
        {
            JobID = jID;
            CommenterID = commenterID;
            IsWorker = isWorker;
            Point = point;
            Comment = comment;
        }
    }
}
