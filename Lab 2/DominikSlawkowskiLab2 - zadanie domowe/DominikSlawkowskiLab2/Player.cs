using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikSlawkowskiLab2
{
    abstract class Player
    {
        protected int Health = 100;
        protected int Stamina = 100;
        protected int Mana = 100;

        public string Name { get; set; }
        
        public int GetHealth()
        {
            return Health;
        }

        public bool IsDead()
        {
            if (Health <= 0)
            {
                return true;
            }
            else return false;
        }

        public int TakeRest()
        {
            if (Health < 90)
            {
                Health += 10;
                return 10;
            }
            else return 0;
        }

        void LevelUp()
        {
            Health += 10;
            Stamina += 10;
            Mana += 10;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
