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

        /// <summary>
        /// Ta metoda zadaje mniejsze obrażenia ale zabiera mniej wytrzymałości naszego bohatera
        /// Metoda losująca wartość zadanych obrażeń przez naszego bohatera, oraz wywołująca metodę klasy Enemy by zmniejszyć przeciwnikowi wartość jego zdrowia.
        /// Metoda zwraca również wartość zadanych obrażeń w celu zmniejszenia wartości progressBarEnemyHealth
        /// </summary>
        /// <param name="enemy"></param>
        /// <returns></returns>
        public int LightSwordAttack(Enemy enemy)
        {
            Stamina -= 10;
            Random rand = new Random();
            int damage = rand.Next(1,10);

            enemy.TakeDamage(damage);
            return damage;
        }
        /// <summary>
        /// Ta metoda zadaje większe obrażenia kosztem większej straty wytrzymałości naszego bohatera
        /// Metoda losująca wartość zadanych obrażeń przez naszego bohatera, oraz wywołująca metodę klasy Enemy by zmniejszyć przeciwnikowi wartość jego zdrowia.
        /// Metoda zwraca również wartość zadanych obrażeń w celu zmniejszenia wartości progressBarEnemyHealth
        /// </summary>
        /// <param name="enemy"></param>
        /// <returns></returns>
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
