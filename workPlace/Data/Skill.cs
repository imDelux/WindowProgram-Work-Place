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
        private string _skillCategory;
        private string _skillName;
        private string _skillDescription;
        private int _expectedWage;

        /// <summary>
        /// Properties
        /// </summary>
        public string SkillCategory { get { return _skillCategory; } set { _skillCategory = value; } }
        public string SkillName { get { return _skillName; } set { _skillName = value; } }
        public string SkillDescription { get { return _skillDescription; } set { _skillDescription = value; } }
        public int ExpectedWage { get { return _expectedWage; } set { _expectedWage = value; } }

        /// <summary>
        /// Basic constructor
        /// </summary>
        public Skill() 
        {
            SkillCategory = string.Empty;
            SkillName = string.Empty;
            SkillDescription = string.Empty;
            ExpectedWage = 0;
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="skillName"></param>
        /// <param name="skillDescription"></param>
        /// <param name="expectedWage"></param>
        public Skill(string skillField,string skillName, string skillDescription, int expectedWage)
        {
            SkillCategory = skillField;
            SkillName = skillName; 
            SkillDescription = skillDescription;
            ExpectedWage = expectedWage;
        }
    }
}
