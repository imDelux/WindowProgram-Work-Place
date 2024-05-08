using EntityModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SummarizeData
    {
        public static float CalculateAveragePoint(Worker worker)
        {
            DbConnection dbConnection = new DbConnection();
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
            DbConnection dbConnection = new DbConnection();
            // Sort
            for (int i = trackList.Count - 1; i >= 1; --i)
            {
                for (int j = 0; j < i; j++)
                {
                    if (dbConnection.FetchEvaluateOfAWorker(trackList[j].PersonID).Count < dbConnection.FetchEvaluateOfAWorker(trackList[j + 1].PersonID).Count)
                    {
                        Worker mid = trackList[j];
                        trackList[j] = trackList[j + 1];
                        trackList[j + 1] = mid;
                    }
                }
            }

            return trackList;
        }

        public static List<Worker> TopMostRatedWorkers(List<Worker> trackList)
        {
            // Sort
            for (int i = trackList.Count - 1; i >= 1; --i)
            {
                for (int j = 0; j < i; j++) 
                {
                    if (CalculateAveragePoint(trackList[j]) < CalculateAveragePoint(trackList[j + 1]))
                    {
                        Worker mid = trackList[j];
                        trackList[j] = trackList[j + 1];
                        trackList[j + 1] = mid;
                    }
                }
            }       

            return trackList;
        }

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
