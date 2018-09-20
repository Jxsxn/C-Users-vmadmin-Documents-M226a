using System;
using System.Security.Cryptography.X509Certificates;

namespace Oddday
{
    public class Player
    {
        
        public static void PlayerRace()
        {
            Console.Write("Are you a [warrior] or [magician]: ");
            var race = Console.ReadLine();
            switch (race.ToLower())
            {
                case "warrior":
                    Console.WriteLine("I see you're a strong warrior!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Are you sure you're a warrior i mean i don't see any muscles hohoho!");
                    CheckChar();
                    break;
                case "magician":
                    Console.WriteLine("Simsala bim.. hahaha... haha.. ha..");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("sorry.. i just like magicians..");
                    CheckChar();
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
                    PlayerRace();
                    break;

                    void CheckChar()
                    {
                        Console.WriteLine("Continue[c] or select again[sa]?");
                        var CheckRace = Console.ReadLine();
                        switch (CheckRace.ToLower())
                        {
                            case "c":
                                var PRace = race;
                                break;
                            case "sa":
                                PlayerRace();
                                break;
                        }
                    }
            }
        }

        public static void PrintStats()
        {
            Console.WriteLine("Stats:");
        }

        public class BasePlayerStats
        {
            public int Health = 20;
            public int Attack = 1;
            public int Defense = 1;
            public int Speed = 10;
            public int Flight = 2;
        }
    }
}