using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikSlawkowskiLab2
{
    abstract class Player
    {
        /// <summary>
        /// Wartości startowe dla naszej postaci.
        /// </summary>
        protected int Health = 100;
        protected int Stamina = 100;
        protected int Mana = 100;

        public string Name { get; set; }
        
        public int GetHealth()
        {
            return Health;
        }

        /// <summary>
        /// Metoda sprawdzająca aktualną wartość naszego zdrowia i zwracająca wartość true, gdy zginiemy.
        /// </summary>
        /// <returns></returns>
        public bool IsDead()
        {
            if (Health <= 0)
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Metoda która, gdy jest to możliwe (wartość życia nie jest wieksza od 90) zwiekasza nasze zdrowie o 10.
        /// </summary>
        /// <returns></returns>
        public int TakeRest()
        {
            if (Health < 90)
            {
                Health += 10;
                return 10;
            }
            else return 0;
        }

        /// <summary>
        /// Metoda odpowiedzialna za zwiększenia naszych statystyk.
        /// </summary>
        void LevelUp()
        {
            Health += 10;
            Stamina += 10;
            Mana += 10;
        }

        /// <summary>
        /// Metoda odpowiedzialna za mniejszenia naszego życia, po otrzymaniu obrażeń.
        /// </summary>
        /// <param name="damage"></param>
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
