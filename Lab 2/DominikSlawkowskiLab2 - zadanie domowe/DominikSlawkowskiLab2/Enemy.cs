using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikSlawkowskiLab2
{
    abstract class Enemy
    {
        protected int Health = 100;
        protected int Fear = 30;

        public int GetHealth()
        {
            return Health;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
