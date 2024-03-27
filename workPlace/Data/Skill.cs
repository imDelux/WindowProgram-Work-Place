using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class Skill
    {
        /// <summary>
        /// Basic attributes
        /// </summary>
        private SkillName _skillName;
        private string _skillDescription;
        private int _expectedWage;

        /// <summary>
        /// Properties
        /// </summary>
        public SkillName SkillName { get { return _skillName; } set { _skillName = value; } }
        public string SkillDescription { get { return _skillDescription; } set { _skillDescription = value; } }
        public int ExpectedWage { get { return _expectedWage; } set { _expectedWage = value; } }

        /// <summary>
        /// Basic constructor
        /// </summary>
        public Skill() 
        {
            SkillName = SkillName.None;
            SkillDescription = string.Empty;
            ExpectedWage = 0;
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="skillName"></param>
        /// <param name="skillDescription"></param>
        /// <param name="expectedWage"></param>
        public Skill(SkillName skillName, string skillDescription, int expectedWage)
        {
            SkillName = skillName; 
            SkillDescription = skillDescription;
            ExpectedWage = expectedWage;
        }
    }
}
