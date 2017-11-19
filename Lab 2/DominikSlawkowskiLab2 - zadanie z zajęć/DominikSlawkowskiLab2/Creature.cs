using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikSlawkowskiLab2
{
    public abstract class Creature
    {
        public string Name { get; set; }

        public int NumberOfLegs { get; set; }

        public int MaxSpeed { get; set; }

        public string ColorOfCorner { get; set; }

        public virtual void DoSomethink()
        {
            Console.WriteLine("abcd");
        }

        protected double GetCurrentSpeed()
        {
            Random rand = new Random();
            return rand.NextDouble() * MaxSpeed;
        }
    }
}
