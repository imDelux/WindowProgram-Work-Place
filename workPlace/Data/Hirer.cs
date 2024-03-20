using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class Hirer : Person
    {
        /// <summary>
        /// Basic constructor
        /// </summary>
        public Hirer() : base() { }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="personID"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="birthDate"></param>
        /// <param name="tel"></param>
        /// <param name="email"></param>
        /// <param name="location"></param>
        public Hirer(string personID, string name, bool gender, DateTime birthDate, string tel, string email, string location, string password)
            : base(personID, name, gender, birthDate, tel, email, location, password) { }
    }
}
