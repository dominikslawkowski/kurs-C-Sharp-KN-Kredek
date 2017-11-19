using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikSlawkowskiLab2
{
    class Knight: Player
    {
        public Knight(string name)
        {
            Name = name;
        }

        public int LightSwordAttack(Enemy enemy)
        {
            Stamina -= 10;
            Random rand = new Random();
            int damage = rand.Next(1,10);

            enemy.TakeDamage(damage);
            return damage;
        }
        public int StrongSwordAttack(Enemy enemy)
        {
            Stamina -= 30;
            Random rand = new Random();
            int damage = rand.Next(20, 30);

            enemy.TakeDamage(damage);

            return damage;
        }
    }
}
