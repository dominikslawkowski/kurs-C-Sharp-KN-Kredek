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

        /// <summary>
        /// Metoda wywołująca metodę klasy Player, w celu przesłania zadanych obrażeń i zmniejszenia wartości życia naszej postaci.
        /// Metoda ta w dodatku zwraca zadana wartość obrażeń aby zmniejszyć wartość w progressBarPlayerHealth
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public int SwordAttack(Player player)
        {
            int damage = 10;
            player.TakeDamage(damage);

            return damage;
        }
        /// <summary>
        /// Metoda sprawdzająca aktualną wartość zdrowia przeciwnika i zwracająca wartość true, gdy on zginie
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
    }
}
