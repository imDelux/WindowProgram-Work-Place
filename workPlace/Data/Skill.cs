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
        private Category _category;
        private SkillName _skillName;
        private string _skillDescription;
        private int _expectedWage;

        /// <summary>
        /// Properties
        /// </summary>
        public Category Category { get { return _category; } set { _category = value; } }
        public SkillName SkillName { get { return _skillName; } set { _skillName = value; } }
        public string SkillDescription { get { return _skillDescription; } set { _skillDescription = value; } }
        public int ExpectedWage { get { return _expectedWage; } set { _expectedWage = value; } }

        /// <summary>
        /// Basic constructor
        /// </summary>
        public Skill() 
        {
            Category = Category.None;
            SkillName = SkillName.None;
            SkillDescription = string.Empty;
            ExpectedWage = 0;
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="category"></param>
        /// <param name="skillName"></param>
        /// <param name="skillDescription"></param>
        /// <param name="expectedWage"></param>
        public Skill(Category category, SkillName skillName, string skillDescription, int expectedWage)
        {
            Category = category;
            SkillName = skillName; 
            SkillDescription = skillDescription;
            ExpectedWage = expectedWage;
        }

    }
}
