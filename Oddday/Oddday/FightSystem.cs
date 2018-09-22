using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Oddday
{
    public class FightSystem
    {
        public void CheckEnemy()
        {
            Random rnd = new Random();
            int CheckEnemyInFight = rnd.Next(1, 3);


            switch (CheckEnemyInFight)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;
            }
        }


        public void InFight()
        {
            var InFght = Console.ReadLine();
            switch (InFght.ToLower())
            {
                case "attack":
                    DamageCalc();
                    break;
                case "Flee":

                    break;
            }
        }

        public void DamageCalc()
        {
            bool isAlive = true;

            /*void CheckAlive()
            {
                if (Enemies.health <= 0)
                {
                    Console.WriteLine("You won!");
                    Items._currentGold += 100;
                    isAlive = false;
                }
                else
                {
                    isAlive = true;
                }
            }*/
        }
    }
}