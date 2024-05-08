using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class Post
    {
        private string _id;
        private string _hirerID;
        private string _title;
        private string _description;
        private DateTime _date;
        private bool _isMorning;
        private string _skillType;
        private float _wage;

        public string ID { get { return _id; } set {  _id = value; } }
        public string HirerID { get { return _hirerID; } set { _hirerID = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }
        public bool IsMorning { get { return _isMorning; } set { _isMorning = value; } }
        public string SkillType { get { return _skillType; } set { _skillType = value; } }
        public float Wage { get { return _wage; } set { _wage = value; } }

        public Post()
        {
            ID = string.Empty;
            HirerID = string.Empty;
            Title = string.Empty;
            Description = string.Empty;
            Date = DateTime.MinValue;
            IsMorning = false;
            SkillType = string.Empty;
            Wage = 0;
        }

        public Post(string id, string hirerID, string title, string description, DateTime date, bool isMorning, string skillType, float wage)
        {
            ID = id;
            HirerID = hirerID;
            Title = title;
            Description = description;
            Date = date;
            IsMorning = isMorning;
            SkillType = skillType;
            Wage = wage;
        }
    }
}
