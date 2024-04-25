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
            string sqlCmd = string.Format("INSERT INTO Skills(PersonID, SkillName, SkillCategory, SkillDescription, ExpectedWage) VALUES ('{0}', '{1}', '{2}', '{3}', {4})", 
                worker.PersonID, newSkill.SkillName, newSkill.SkillCategory, newSkill.SkillDescription, newSkill.ExpectedWage);
            dbConn.Execute(sqlCmd);
        }
    }
}
