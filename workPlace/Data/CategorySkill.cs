using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class CategorySkill
    {
        private string _id;
        private string _type;

        public string Id { get { return _id; } set { _id = value; } }
        public string Type { get { return _type; } set { _type = value; } }

        public CategorySkill() 
        { }

        public CategorySkill(string id, string type, int numbWorker)
        {
            this.Id = id;
            this.Type = type;
        }
    }
}
