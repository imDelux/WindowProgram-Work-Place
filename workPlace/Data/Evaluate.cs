using System;
using System.Collections.Generic;
using System.Linq;
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
        private float _point;
        private string _comment;

        public string JobID { get { return _jobID; } set { _jobID = value; } }
        public float Point { get { return _point; } set { _point = value; } }
        public string Comment { get { return _comment; } set { _comment = value; } }

        /// <summary>
        /// Basic constructor
        /// </summary>
        public Evaluate() 
        {
            JobID = string.Empty;
            Point = 0;
            Comment = string.Empty;
        }
    }
}
