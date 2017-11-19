using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikSlawkowskiLab2
{
    class Skeleton: Enemy
    {
        protected string BonesColor = "white";

        public int SwordAttack(Player player)
        {
            int damage = 10;
            player.TakeDamage(damage);

            return damage;
        }
        public bool IsDead()
        {
            if (Health <= 0)
            {
                return true;
            }
            else return false;
        }
    }
}
