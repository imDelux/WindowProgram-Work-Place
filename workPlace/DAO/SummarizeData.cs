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
        /// <summary>
        /// Calculate average review point of A WORKER
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
        public static float CalculateAveragePoint(Worker worker)
        {
            // Fetch data
            DbConnection dbConnection = new DbConnection();
            List<Evaluate> evaluateList = dbConnection.FetchEvaluateOfAWorker(worker.PersonID);

            // Calculate and return
            float sum = 0;
            foreach (Evaluate evaluate in evaluateList)
            {
                sum += evaluate.Point;
            }
            return evaluateList.Count != 0 ? ((int)(sum * 10 / evaluateList.Count)) / 10.0f : 0;
        }

        /// <summary>
        /// Rearrange a list of worker by total received jobs in descending order
        /// </summary>
        /// <param name="trackList"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Rearrange a list of worker by average review point in descending order
        /// </summary>
        /// <param name="trackList"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Filter out list of worker that related to an inputed key
        /// </summary>
        /// <param name="trackList"></param>
        /// <param name="key"></param>
        /// <returns></returns>
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
