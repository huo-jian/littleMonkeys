using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTechnique_EONIX
{
    /// <summary>
    /// A trainer is a person with a monkey.
    /// </summary>
    class Trainer : Person
    {

        private Monkey Monkey;

        public Trainer(String firstname, String lastname, Monkey monkey)
        {
            this.SetFirstname(firstname);
            this.SetLastname(lastname);
            this.Monkey = monkey;
        }


        public void ExecuteAllTricks()
        {
            Console.WriteLine(base.ToString() + " demande au singe " + Monkey.GetName() + " de faire ses tours");
            Monkey.ExecuteAllTricks();

        }

        public override String ToString()
        {
            return base.ToString() + ", " + Monkey.ToString();
        }


    }
}
