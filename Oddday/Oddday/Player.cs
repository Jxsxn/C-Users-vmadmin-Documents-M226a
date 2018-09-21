using System;
using System.Dynamic;
using System.Runtime.Remoting.Activation;
using System.Security.Cryptography.X509Certificates;

namespace Oddday
{
    public class Player
    {
        public string Player1 = Oddday.PlayerName;
        public int Lvl = 1;
        public int PlayerExp = 0;
        public int ExpForLvlUp = 50 + (Lvl * 20);

        public static void LvlUp()
        {
            int i = Lvl;
            if (PlayerExp == ExpForLvlUp)
            {
                i++;
                Console.WriteLine("Level up!");
                Console.WriteLine("You're level is now: " + Lvl);
            }
        }


        public static void CheckEntryChar()
        {
            Console.Write("Entry [warrior] or [magician]: ");
            var race = Console.ReadLine();
            switch (race.ToLower())
            {
                case "warrior":
                    Console.WriteLine("I see you're a strong warrior!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Are you sure you're a warrior i mean i don't see any muscles hohoho!");
                    CheckChar();
                    Oddday.PlayerRace = Warrior.BaseStatsWarrior.Race;
                    BaseStatsPlayer.Health += Warrior.BaseStatsWarrior.Health;
                    BaseStatsPlayer.Attack += Warrior.BaseStatsWarrior.Attack;
                    BaseStatsPlayer.Defense += Warrior.BaseStatsWarrior.Defense;
                    BaseStatsPlayer.Speed += Warrior.BaseStatsWarrior.Speed;
                    BaseStatsPlayer.Flight += Warrior.BaseStatsWarrior.Flight;
                    break;
                case "magician":
                    Console.WriteLine("Simsala bim.. hahaha... haha.. ha..");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("sorry.. i just like magicians..");
                    CheckChar();
                    Oddday.PlayerRace = Magician.BaseStatsMagician.Race;
                    BaseStatsPlayer.Health += Magician.BaseStatsMagician.Health;
                    BaseStatsPlayer.Attack += Magician.BaseStatsMagician.Attack;
                    BaseStatsPlayer.Defense += Magician.BaseStatsMagician.Defense;
                    BaseStatsPlayer.Speed += Magician.BaseStatsMagician.Speed;
                    BaseStatsPlayer.Flight += Magician.BaseStatsMagician.Flight;
                    break;
                case "player":
                    Console.WriteLine(
                        "You sure? This will make it difficult af and btw how did you know this one is even available?! Hacker exposed!!!");
                    Console.ReadLine();
                    CheckChar();
                    break;
                default:
                    Console.WriteLine("This race does not exist!");
                    Console.WriteLine("Don't worry about it we all do typo's");
                    CheckEntryChar();
                    break;
            }

            void CheckChar()
            {
                Console.WriteLine("Continue[c] or select again[sa]?");
                var CheckRace = Console.ReadLine();
                switch (CheckRace.ToLower())
                {
                    case "c":
                        break;
                    case "sa":
                        CheckEntryChar();
                        break;
                }
            }
        }


        public static void PrintStats()
        {
            Console.WriteLine("Stats:    ");
            Console.WriteLine("Race:    " + BaseStatsPlayer.Race);
            Console.WriteLine("Health:    " + BaseStatsPlayer.Health);
            Console.WriteLine("Attack:    " + BaseStatsPlayer.Attack);
            Console.WriteLine("Defense:    " + BaseStatsPlayer.Defense);
            Console.WriteLine("Speed:    " + BaseStatsPlayer.Speed);
            Console.WriteLine("Chance of fleeing:    " + BaseStatsPlayer.Flight);
        }

        public class BaseStatsPlayer
        {
            public static string Race = "Player";
            public static int Health = 20;
            public static int Attack = 1;
            public static int Defense = 1;
            public static int Speed = 10;
            public static int Flight = 2;
        }
    }
}