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

        public Horse(string horseName, int numberOfLegs, string colorOfCorner)
        {
            Name = horseName;
            NumberOfLegs = numberOfLegs;
            ColorOfCorner = colorOfCorner;
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
