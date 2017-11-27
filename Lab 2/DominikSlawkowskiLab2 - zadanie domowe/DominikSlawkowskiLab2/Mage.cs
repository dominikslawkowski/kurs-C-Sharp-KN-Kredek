using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikSlawkowskiLab2
{
    class Mage: Player
    {
        /// <summary>
        /// Początkowa ilość zaklęć naszej postaci
        /// </summary>
        protected int Scroll = 3;

        public Mage(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Metoda odpowiedzialna za wylosowanie wartości obrażeń zadanych przez maga i wywołanie metody klasy Enemy w celu zmniejszeniu jego zycia
        /// </summary>
        /// <param name="enemy"></param>
        void ThrowFireBall(Enemy enemy)
        {
            Mana -= 20;
            Random rand = new Random();
            int damage = rand.Next(1, 10);

            enemy.TakeDamage(damage);
        }

        /// <summary>
        /// Metoda zmniejszająca ilość posiadanych zwojów po jego wykorzystaniu i zwiększająca nasze życie
        /// </summary>
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
