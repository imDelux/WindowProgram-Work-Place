using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class Person
    {
        /// <summary>
        /// Private attribute store some basic information about a person
        /// </summary>
        private string _personID;
        private string _name;
        private int _age;
        private string _tel;
        private string _email;
        private string _location;
        private string _password;

        
        /// <summary>
        /// Public attribute use to get - set private attribute
        /// </summary>
        public string PersonID { get { return _personID; } set { _personID = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public string Telephone { get { return _tel; } set { _tel = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Location { get { return _location; } set { _location = value; } }
        public string Password { get { return _password; } set { _password = value; } }

        /// <summary>
        /// Basic constructor - set empty value for all attributes
        /// </summary>
        public Person() 
        {
            PersonID = string.Empty;
            Name = string.Empty;
            Age = 0;
            Telephone = string.Empty;
            Email = string.Empty;
            Location = string.Empty;
            Password = string.Empty;
        }

        /// <summary>
        /// Initialize some information for object
        /// </summary>
        /// <param name="personID">Person identification code</param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="birthDate"></param>
        /// <param name="tel"></param>
        /// <param name="email"></param>
        /// <param name="location"></param>
        public Person(string personID, string name,int age, string tel, string email, string location, string password)
        {
            PersonID = personID;
            Name = name;
            Age = age;
            Telephone = tel;
            Email = email;
            Location = location;
            Password = password;
        }
    }
}
