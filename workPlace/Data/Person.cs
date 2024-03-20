using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Person
    {
        /// <summary>
        /// Private attribute store some basic information about a person
        /// </summary>
        #region Attributes

        private string _personID;
        private string _name;
        private bool _gender;
        private DateTime _birthDate;
        private string _tel;
        private string _email;
        private string _location;

        #endregion

        
        /// <summary>
        /// Public attribute use to get - set private attribute
        /// </summary>
        #region

        public string PersonID { get { return _personID; } set { _personID = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public bool Gender { get { return _gender; } set { _gender = value; } }
        public DateTime BirthDate { get { return _birthDate; } set { _birthDate = value; } }
        public string Telephone { get { return _tel; } set { _tel = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Location { get { return _location; } set { _location = value; } }

        #endregion

        /// <summary>
        /// Basic constructor - set empty value for all attributes
        /// </summary>
        public Person() 
        {
            PersonID = string.Empty;
            Name = string.Empty;
            Gender = false;
            BirthDate = DateTime.MinValue;
            Telephone = string.Empty;
            Email = string.Empty;
            Location = string.Empty;
        }

        public Person(string personID, string name, bool gender, DateTime birthDate, string tel, string email, string location)
        {
            PersonID = personID;
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Telephone = tel;
            Email = email;
            Location = location;
        }
    }
}
