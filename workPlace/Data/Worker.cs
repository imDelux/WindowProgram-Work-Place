using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModel
{
    public class Worker : Person
    {
        /// <summary>
        /// Basic constructor
        /// </summary>
        public Worker() : base() 
        {
            
        }
        
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        public Worker(string personID, string name, int age, string tel, string email, string location,string password) 
            : base(personID, name, age, tel, email, location, password)
        {
            
        }
    }
}
