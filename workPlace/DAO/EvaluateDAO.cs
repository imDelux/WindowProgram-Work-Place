using EntityModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            if (evaluates.Count > 0)
            {
                return ((int)(sum * 10 / evaluates.Count)) / 10.0f;
            }
            else
            {
                return 0;
            }
        }

        public List<Image> GetReviewImages(string reviewJobID)
        {
            List<Image> result = new List<Image>();
            Image reviewImg;
            string filePath = Path.Combine(Environment.CurrentDirectory, @"EvaluatePhotos\");
            string imageName = string.Empty;

            for (int i = 1; i < 4; i++)
            {
                // Set null
                reviewImg = null;

                // Set image name
                imageName = @"eval_" + i.ToString() + @"_" + reviewJobID;

                // Fetch image
                if (File.Exists(Path.Combine(filePath, imageName + @".jpeg")))
                {
                    reviewImg = new Bitmap(Path.Combine(filePath, imageName + @".jpeg"));
                }
                else if (File.Exists(Path.Combine(filePath, imageName + @".jpg")))
                {
                    reviewImg = new Bitmap(Path.Combine(filePath, imageName + @".jpg"));
                }
                else if (File.Exists(Path.Combine(filePath, imageName + @".gif")))
                {
                    reviewImg = new Bitmap(Path.Combine(filePath, imageName + @".gif"));
                }
                else if (File.Exists(Path.Combine(filePath, imageName + @".bmp")))
                {
                    reviewImg = new Bitmap(Path.Combine(filePath, imageName + @".bmp"));
                }

                // Check null
                if (reviewImg != null) result.Add(reviewImg);
            }

            return result;
        }
    }
}
