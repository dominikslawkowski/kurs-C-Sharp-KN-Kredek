using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominikSlawkowskiLab2
{
    abstract class Enemy
    {
        /// <summary>
        /// Wartości startowe dla każdego przewciwnika
        /// </summary>
        protected int Health = 100;
        protected int Fear = 30;

        /// <summary>
        /// Metoda zwracająca aktualne zdrowie przeciwnika
        /// </summary>
        /// <returns></returns>
        public int GetHealth()
        {
            return Health;
        }

        /// <summary>
        /// Metoda zmniejszająca wartość życia postaci po otrzymaniu obrażeń
        /// </summary>
        /// <param name="damage"></param>
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
