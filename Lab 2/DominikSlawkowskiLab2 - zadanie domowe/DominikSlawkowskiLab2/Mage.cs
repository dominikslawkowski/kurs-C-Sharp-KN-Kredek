using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikSlawkowskiLab2
{
    class Mage: Player
    {
        protected int Scroll = 3;

        public Mage(string name)
        {
            Name = name;
        }

        void ThrowFireBall(Enemy enemy)
        {
            Mana -= 20;
            Random rand = new Random();
            int damage = rand.Next(1, 10);

            enemy.TakeDamage(damage);
        }

        void UseScroll()
        {
            if(Scroll > 0)
            {
                Scroll--;
                Health += 20;
            }
        }
    }
}
