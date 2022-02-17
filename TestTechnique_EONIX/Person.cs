using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTechnique_EONIX
{
    /// <summary>
    /// Super-class Person that defines firstname and lastname
    /// </summary>
    class Person
    {
        private String Firstname { get; set; }
        private String Lastname { get; set; }

        public void SetFirstname(String firstname)
        {
            this.Firstname = firstname;
        }

        public String GetLastname()
        {
            return this.Lastname;
        }

        public void SetLastname(String lastname)
        {
            this.Lastname = lastname;
        }

        public String GetFirstname()
        {
            return this.Firstname;
        }


        public override string ToString()
        {
            return Firstname + ", " + Lastname;
        }
    }
}