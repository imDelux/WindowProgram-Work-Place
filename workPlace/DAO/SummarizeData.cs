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
        public void TopMostCanceledWorkers(List<Worker> workerList, List<List<Evaluate>> listEvaluations)
        {
            DbConnection dbConnection = new DbConnection();
            List<List<Evaluate>> listEvaluate = new List<List<Evaluate>>();

            // Fetch data
            List<Worker> workers = dbConnection.FetchWorkerList();
            for (int i = 0; i < workers.Count; i++)
            {
                List<Evaluate> evaluateOfAWorker = dbConnection.FetchCanceledJobOfAWorker(workers[i].PersonID);
                listEvaluate.Add(evaluateOfAWorker);
            }

            // Re-arrange data
            for (int i = listEvaluate.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (listEvaluate[j].Count < listEvaluate[j + 1].Count)
                    {
                        List<Evaluate> midEva = listEvaluate[j];
                        listEvaluate[j] = listEvaluate[j + 1];
                        listEvaluate[j + 1] = midEva;

                        Worker midWorker = workers[j];
                        workers[j] = workers[j + 1];
                        workers[j + 1] = midWorker;
                    }
                }
            }
        }

        public void TopMostRatedWorkers(List<Worker> workerList, List<List<Evaluate>> listEvaluations)
        {
            DbConnection dbConnection = new DbConnection();
            List<List<Evaluate>> listEvaluate = new List<List<Evaluate>>();

            // Fetch data
            List<Worker> workers = dbConnection.FetchWorkerList();
            for (int i = 0; i < workers.Count; i++)
            {
                List<Evaluate> evaluateOfAWorker = dbConnection.FetchEvaluateOfAWorker(workers[i].PersonID);
                listEvaluate.Add(evaluateOfAWorker);
            }

            // Re-arrange data
            for (int i = listEvaluate.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    float total1 = 0, total2 = 0;

                    foreach (Evaluate eval in listEvaluate[j])
                    {
                        total1 += eval.Point;
                    }

                    foreach (Evaluate eval in listEvaluate[j + 1])
                    {
                        total2 += eval.Point;
                    }

                    if ((total1 / listEvaluate[j].Count) < (total2 / listEvaluate[j + 1].Count))
                    {
                        List<Evaluate> midEva = listEvaluate[j];
                        listEvaluate[j] = listEvaluate[j + 1];
                        listEvaluate[j + 1] = midEva;

                        Worker midWorker = workers[j];
                        workers[j] = workers[j + 1];
                        workers[j + 1] = midWorker;
                    }
                }
            }
        }
    }
}
