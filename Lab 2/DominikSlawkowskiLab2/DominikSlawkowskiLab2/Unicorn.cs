using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikSlawkowskiLab2
{
    class Unicorn: Horse
    {
        static readonly int unicornMaxSpeed = 500;

        public bool Corner { get; set; }

        protected string ColorOfSequins { get; set; }

        public Unicorn(string unicornName, int numberOfLegs, string colorOfSequins, bool corner): base(unicornName, numberOfLegs)
        {
            ColorOfSequins = colorOfSequins;
            Corner = corner;
            MaxSpeed = unicornMaxSpeed;
        }

        public Unicorn()
        {
            MaxSpeed = unicornMaxSpeed;
        }

    }
}
