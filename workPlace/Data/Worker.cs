using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class Worker : Person
    {
        /// <summary>
        /// Skill list of a worker
        /// </summary>
        private List<Skill> _skillList;
        
        public List<Skill> SkillList { get {  return _skillList; } set {  _skillList = value; } }

        /// <summary>
        /// Basic constructor
        /// </summary>
        public Worker() : base() 
        {
            SkillList = new List<Skill>();
        }
        
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        public Worker(string personID, string name, bool gender, DateTime birthDate, string tel, string email, string location,string password, List<Skill> skills) 
            : base(personID, name, gender, birthDate, tel, email, location, password)
        {
            SkillList = skills;
        }
    }
}
