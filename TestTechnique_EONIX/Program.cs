using System;

namespace TestTechnique_EONIX
{
    class Program
    {
        static void Main(string[] args)
        {

            ////////////////////////////////////////////////////////////////

            Monkey m1 = new Monkey("Einstein");
            Monkey m2 = new Monkey("Daniel");

            Trick trick1 = new Trick("Mache sur les main", TrickType.ACROBATICS);
            Trick trick2 = new Trick("Joue du violon en petant", TrickType.MUSIC);

            m1.AddTrick(trick1);
            m2.AddTrick(trick1);
            m1.AddTrick(trick2);

            Trainer t1 = new Trainer("Michel", "trainer1", m1);
            Trainer t2 = new Trainer("Jean-Phi","trainer2", m2);

            Spectator spectator = new Spectator("Albert", "spectator");
            m1.Attach(spectator);
            m2.Attach(spectator);

            ////////////////////////////////////////////////////////////////
            Console.WriteLine("Les tours commencent");

            t1.ExecuteAllTricks();
            t2.ExecuteAllTricks();


            ////////////////////////////////////////////////////////////////
            Console.WriteLine("FINISHED");
            Console.ReadLine();
        }
    }
}
