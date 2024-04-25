using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class Worker : Person
    {
        private bool _isActive;
        private string _skillName;
        private string _skillDescription;
        private string _skillType;
        private int _expectedWage;

        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public string SkillName { get { return _skillName; } set { _skillName = value; } }
        public string SkillDescription { get { return _skillDescription; } set { _skillDescription = value; } }
        public string SkillType { get { return _skillType; } set { _skillType = value; } }
        public int ExpectedWage { get { return _expectedWage; } set { _expectedWage = value; } }


        /// <summary>
        /// Basic constructor
        /// </summary>
        public Worker() : base() 
        {
            IsActive = false;
            SkillName = string.Empty;
            SkillDescription = string.Empty;
            SkillType = string.Empty;
            ExpectedWage = 0;
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        public Worker(string personID, string name, int age, string tel, string email, string location, string password, bool isActive, string skillName, string skillDescription, string skillType, int expectedWage) 
            : base(personID, name, age, tel, email, location, password)
        {
            IsActive = isActive;
            SkillName = skillName;
            SkillDescription = skillDescription;
            SkillType = skillType;
            ExpectedWage = expectedWage;
        }
    }
}
