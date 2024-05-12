using EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PostDAO
    {
        DbConnection dbConn = new DbConnection();

        public string Add(Post nPost)
        {
            string strCmd = string.Format("INSERT INTO Post(ID, HirerID, Title, Description , Date, IsMorning, SkillType, Wage) " +
                "VALUES (NEWID(), '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                nPost.HirerID, nPost.Title, nPost.Description, nPost.Date, nPost.IsMorning, nPost.SkillType, nPost.Wage);
            return dbConn.Execute(strCmd);
        }

        public string Delete(Post post)
        {
            string strCmd = string.Format("DELETE FROM Post WHERE ID = '{0}';" +
                "DELETE FROM Apply WHERE PostID = '{0}'", post.ID);
            return dbConn.Execute(strCmd);
        }

        /// <summary>
        /// Add an apply information when a worker apply to a job
        /// </summary>
        /// <param name="post"></param>
        /// <param name="worker"></param>
        /// <returns></returns>
        public string Apply(Post post, Worker worker)
        {
            string strCmd = string.Format("INSERT INTO Apply(PostID, WorkerID) VALUES ('{0}','{1}')", post.ID, worker.PersonID);
            return dbConn.Execute(strCmd);
        }
    }
}
