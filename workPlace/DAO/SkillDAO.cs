using EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SkillDAO
    {
        DbConnection dbConn = new DbConnection();

        public void Add(Skill newSkill, Person worker)
        {
            string sqlCmd = string.Format("INSERT INTO Skills(PersonID, SkillName, SkillDescription, ExpectedWage) VALUES ('{0}', '{1}', '{2}', {3})", 
                worker.PersonID, newSkill.SkillName.ToString(), newSkill.SkillDescription, newSkill.ExpectedWage);
            dbConn.Execute(sqlCmd);
        }
    }
}
