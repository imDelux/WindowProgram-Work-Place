using EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SummarizeData
    {
        DbConnection dbConnection = new DbConnection();

        private float CalculateAveragePoint(Worker worker)
        {
            List<Evaluate> evaluateList = dbConnection.FetchEvaluateOfAWorker(worker.PersonID);
            float sum = 0;
            foreach (Evaluate evaluate in evaluateList)
            {
                sum += evaluate.Point;
            }
            return sum/evaluateList.Count;
        }

        public static List<Worker> TopMostReceiveJobWorker(List<Worker> trackList)
        {
            List<Worker> result = new List<Worker>();   

            return result;
        }

        //public static List<Worker> TopMostRatedWorkers(List<Worker> trackList)
        //{
        //    // Sort
        //    for (int i = trackList.Count - 1; i >= 0; --i)
        //    {
        //        for (int j = 0; j <)
        //    }


        //    return trackList;
        //}

        public static List<Worker> RelatedWorker(List<Worker> trackList, string key)
        {
            List<Worker> result = new List<Worker>();

            foreach (Worker worker in trackList)
            {
                if ((worker.Name.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0
                    || worker.SkillName.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0
                    || worker.Location.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0)
                    && worker.IsActive)
                {
                    result.Add(worker);
                }
            }

            return result;
        }
    }
}
