using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class CategorySkill
    {
        private string _categoryName;
        private List<string> skillList;
        private int _numbWorker;

        public string CategoryName { get { return _categoryName; } set { _categoryName = value; } }
        public List<string> SkillList { get { return skillList; } set { skillList = value; } }
        public int NumbWorker { get { return _numbWorker; } set { _numbWorker = value; } }

        public CategorySkill() 
        { 
            CategoryName = string.Empty;
            SkillList = new List<string>();
        }

        public CategorySkill(string categoryName, List<string> skillList, int numbWorker)
        {
            this.CategoryName = categoryName;
            this.SkillList = skillList;
            this.NumbWorker = numbWorker;
        }
    }
}
