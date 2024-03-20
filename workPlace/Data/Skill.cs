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

        /// <summary>
        /// Properties
        /// </summary>
        public SkillName SkillName { get { return _skillName; } set { _skillName = value; } }
        public string SkillDescription { get { return _skillDescription; } set { _skillDescription = value; } }

        /// <summary>
        /// Basic constructor
        /// </summary>
        public Skill() 
        {
            SkillName = SkillName.None;
            SkillDescription = string.Empty;
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="skillName"></param>
        /// <param name="skillDescription"></param>
        public Skill(SkillName skillName, string skillDescription)
        {
            SkillName = skillName; 
            SkillDescription = skillDescription;
        }
    }
}
