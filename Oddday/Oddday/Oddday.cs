using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;

namespace Oddday
{
    public class Oddday
    {
        public static string PlayerName;
        /*public static string PlayerRace = race;*/


        public void start()
        {
            Console.WriteLine("Goodmorning youngling!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please tell me your name:");
            PlayerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("I see.. " + PlayerName + " that's a great Name!");
            Console.ReadLine();
            Console.WriteLine("So now " + PlayerName + " are you a warrior or magician?");
            CheckEntryChar();

            Console.WriteLine("You wake up in the morning filled up with determination!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(PlayerName + ":  Today's the day big boy...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(PlayerName + ":  The day.. i'll safe my village..");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(PlayerName + ":  But first i need a healthy breakfast!");
            Console.WriteLine(PlayerName + ":  true hero's never skip breakfast!");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(
                "Before you go out to do whatever you wanna do i'll have to explain the game machanics..");
            Console.WriteLine("Well.. just press some random buttons everything else is pretty much self explaining");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(PlayerName + ":  Guess with [m] I can open the menu..");
            CheckMenu();
            Console.WriteLine(
                "So that was you menu.. not that much aight? but don't worry you can buy food in the marketplace");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Where do you wanna go?");
            Overworld.TravelMode();


            /*if (Console.ReadKey().Key == ConsoleKey.M)
            {
                PrintMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine(PlayerName + ":  So you just ignore that i said with [m] you could open the Menu?..");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine(
                    "Well emmm... the game expected that you would press [m] and im just an if loop soooo....");
                Console.ReadLine();
                Console.WriteLine("try again");
            }*/
        }

        private static void CheckMenu()
        {
            var CheckMenu = Console.ReadLine();
            switch (CheckMenu.ToLower())
            {
                case "m":
                    PrintMenu();
                    break;
                default:
                    Console.WriteLine(PlayerName +
                                      ":  So you just ignore that i said with [m] you could open the Menu?..");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("We'll get it this time right? ;)");
                    Console.ReadLine();
                    Console.WriteLine("try again");
                    Console.ReadLine();

                    break;
            }

            return;
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


        private static void PrintMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("    press [b] to open your bag");
            Console.WriteLine("    press [s] to see your stats");
            Console.WriteLine("    press [q] to quit the game");
            Console.WriteLine("    press [r] to restart the game");
            Console.WriteLine("    [c] close the menu");
            var PrintMenu = Console.ReadLine();
            switch (PrintMenu.ToLower())
            {
                case "b":
                    Console.WriteLine("Bag: ");
                    Bag.PrintBag();
                    break;

                case "s":
                    Console.WriteLine("Stats");
                    Player.PrintStats();
                    break;

                case "q":
                    Console.WriteLine("You sure you want to quit? :(");
                    QuitGame();
                    break;

                case "r":
                    RestartGame();
                    break;

                case "c":
                    Console.WriteLine("close menu");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("");
                    break;
            }
        }


        private static void YouSure()
        {
            Console.WriteLine(PlayerName + "You sure you want to? :(");
            Console.WriteLine("    Entry: [yes] or [no]");
            var YouSure = Console.ReadLine();
            switch (YouSure.ToLower())
            {
                case "yes":
                    break;
                case "no":
                    PrintMenu();
                    break;
                default:
                    Console.WriteLine("please one of these:    [yes] or [no]?");
                    break;
            }
        }

        public static void RestartGame()
        {
            Console.WriteLine("Restarts Game");
        }

        public static void QuitGame()
        {
            Console.WriteLine("QuitGame");
        }
    }
}