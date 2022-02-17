using System;
using System.Collections.Generic;

namespace TestTechnique_EONIX
{
    /// <summary>
    /// Monkey does tricks
    /// </summary>
    public class Monkey : IMonkey
    {
        private String Name { get; set; }
        private List<Trick> TricksList;
        private List<ISpectator> Observers = new List<ISpectator>();

        public TrickType State { get; set; } = TrickType.NOTHING;


        public Monkey(String name)
        {
            this.Name = name;
            TricksList = new List<Trick>();
        }


        public void AddTrick(Trick trick)
        {
            TricksList.Add(trick);
        }

        /// <summary>
        /// The monkey execute its tricks in order of tricklist
        /// </summary>
        public void ExecuteAllTricks()
        {
            foreach (Trick tr in TricksList)
            {
                this.State = tr.GetTrickType();
                Console.WriteLine(this.GetName() + ", " + tr.GetName());
                this.Notify();
            }
        }
        public String GetName()
        {
            return this.Name;
        }

        public Trick GetTrick(int index)
        {
            return TricksList[index];
        }

        public void Attach(ISpectator observer)
        {
            this.Observers.Add(observer);
        }

        public void Detach(ISpectator observer)
        {
            this.Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update(this);
            }
        }

        public override string ToString()
        {
            return this.Name + ", " + this.State;
        }


        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Monkey m = (Monkey)obj;
                return (this.Name == m.GetName());
            }
        }
    }
}
