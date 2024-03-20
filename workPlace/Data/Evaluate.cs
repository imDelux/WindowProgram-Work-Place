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
        private Job _job;
        private float _point;
        private string _comment;

        public Job Job { get { return _job; } set { _job = value; } }
        public float Point { get { return _point; } set { _point = value; } }
        public string Comment { get { return _comment; } set { _comment = value; } }

        /// <summary>
        /// Basic constructor
        /// </summary>
        public Evaluate() 
        {
            Job = new Job();
            Point = 0;
            Comment = string.Empty;
        }
    }
}
