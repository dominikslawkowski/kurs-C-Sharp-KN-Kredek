using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikSlawkowskiLab2
{
    public class Horse: Creature, IMovable
    { 
        public Horse()
        {
         
        }

        public Horse(string horseName, int numberOfLegs)
        {
            Name = horseName;
            NumberOfLegs = numberOfLegs;
        }

        public void Move()
        {
            Console.WriteLine("prfffffff");
        }

        public override void DoSomethink()
        {
            base.DoSomethink();
        }
    }
}
