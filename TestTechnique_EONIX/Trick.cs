using System;

namespace TestTechnique_EONIX
{
    /// <summary>
    /// Monkey's trick
    /// </summary>
    public class Trick
    {
        private String Name { get; set; }
        private TrickType Type { get; set; }

        public Trick(String name, TrickType type)
        {
            this.Name = name;
            this.Type = type;
        }

        public TrickType GetTrickType()
        {
            return this.Type;
        }

        public String GetName()
        {
            return this.Name;
        }

        public override string ToString()
        {
            return this.Name + ", " + this.Type;
        }
    }
}
