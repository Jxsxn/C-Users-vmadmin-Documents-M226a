using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Oddday
{
    public class FightSystem
    {
        public static void CheckRaceInFight()
        {
            var CheckRInFight = Console.ReadLine();
            switch (CheckRInFight)
            {
                case "warrior":
                    if (Oddday.PlayerRace == Warrior.BaseStatsWarrior.Race)
                    {
                        InFight();
                    }

                    break;

                case "Magician":
                    if (Oddday.PlayerRace == Magician.BaseStatsMagician.Race)
                    {
                        InFight();
                    }

                    break;
            }
        }

        public static void CheckEnemy()
        {
            Random rnd = new Random();
            int CheckEnemyInFight = rnd.Next(1, 3);


            switch (CheckEnemyInFight)
            {
                case 1:
                    var hg = GhostDog.Health;
                    var ag = GhostDog.Attack;
                    var dg = GhostDog.Defense;
                    var sg = GhostDog.Speed;
                    break;

                case 2:
                    var hv = VampireCat.Health;
                    var av = VampireCat.Attack;
                    var dv = VampireCat.Defense;
                    var sv = VampireCat.Speed;
                    break;

                case 3:
                    var hw = WerewolfSpider.Health;
                    var aw = WerewolfSpider.Attack;
                    var dw = WerewolfSpider.Defense;
                    var sw = WerewolfSpider.Speed;
                    break;
            }
        }

        public static void InFight()
        {

            var InFght = Console.ReadLine();
            switch (InFght.ToLower())
            {
                case "attack":
                    //DamageCalc();
                    break;
                case "act":
                    Act.Acting();
                    break;
                case "items":
                    Items.PrintItems();
                    break;
                case "Flee":

                    break;
            }
        }

        public static void DamageCalc()
        {
            bool isAlive = true;
            void CheckAlive()
            {
                /*if (health <= 0)
                {
                    Console.WriteLine("You won!");
                    isAlive = false;
                }
                else
                {
                    isAlive = true;
                }*/
            }
            GhostDog.Health -= (Player.BaseStatsPlayer.Attack + Warrior.AttacksWar.Fight - GhostDog.Defense);
            
        }
    }
}