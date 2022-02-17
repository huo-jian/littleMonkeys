using System;

namespace TestTechnique_EONIX
{
    /// <summary>
    /// A spectator is a person 
    /// </summary>
    class Spectator : Person, ISpectator
    {
        
        public Spectator(String firstname, String lastname)
        {
            this.SetFirstname(firstname);
            this.SetLastname(lastname);
  
        }

        /// <summary>
        /// Spectator reacts when the monkey does a trick (the monkey notify the spectator. 
        /// He can sleep, danse or whistle depends on the trick type
        /// </summary>
        /// <param name="monkey">The monkey</param>
        public void Update(IMonkey monkey)
        {
            if ((monkey as Monkey).State == TrickType.MUSIC)
            {
                Siffle();
            }
            else if ((monkey as Monkey).State == TrickType.ACROBATICS)
            {
                Danse();
            }
            else
            {
                Dors();
            }
        }


        public override string ToString()
        {
            return base.ToString();
        }

        private void Danse()
        {
            Console.WriteLine("Spectateur " + this.GetFirstname() + " danse");
        }

        private void Siffle()
        {
            Console.WriteLine("Spectateur " + this.GetFirstname() + " siffle");
        }

        private void Dors()
        {
            Console.WriteLine("Spectateur " + this.GetFirstname() + " s'ennuie et fini par s'endormir");
        }




    }
}
