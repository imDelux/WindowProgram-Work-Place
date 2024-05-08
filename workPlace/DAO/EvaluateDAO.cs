using EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EvaluateDAO
    {
        DbConnection conn = new DbConnection();

        public string Add(Evaluate evaluate)
        {
            string strCmd = string.Format("INSERT INTO Evaluate(JobID, CommenterID, IsWorker , Point, Comment) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", evaluate.JobID, evaluate.CommenterID, evaluate.IsWorker, evaluate.Point, evaluate.Comment);
            return conn.Execute(strCmd);
        }

        public float AveragePoint(List<Evaluate> evaluates)
        {
            float sum = 0;
            foreach (Evaluate eval in evaluates)
            {
                sum += eval.Point;
            }
            return ((int)(sum * 10 / evaluates.Count))/10.0f;
        }
    }
}
