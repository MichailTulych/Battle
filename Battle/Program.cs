using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int playerHealth = 100;
            int playerDamage =rnd.Next(1,10);
            int enemyHealth = 90;
            int enemyDamage = rnd.Next(1, 10);

            while (playerHealth>0 && enemyHealth>0)
            {
                playerHealth -= enemyDamage;
                enemyHealth -= playerDamage;

                Console.WriteLine($"Здоровье игрока: {playerHealth}, Здоровье противника: {enemyHealth}");
            }
            if (playerHealth <= 0 && enemyHealth <= 0)
                Console.WriteLine("Ничья!");
            else if (enemyHealth <= 0)
                Console.WriteLine("Победил игрок!");
            else if (playerHealth <= 0)
                Console.WriteLine("Победил противник!");
            Console.ReadKey();
        }
        
    }
}
