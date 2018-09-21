using System;

namespace Oddday
{
    public class Menu
    {
        public void CheckMenu()
        {
            Console.Clear();
            Console.WriteLine(Oddday.PlayerName + ":  Guess with [m] I can open the menu..");
            var ChckMenu = Console.ReadLine();
            switch (ChckMenu.ToLower())
            {
                case "m":
                    PrintMenu();
                    break;
                default:
                    Console.WriteLine(Oddday.PlayerName +
                                      ":  So you just ignore that i said with [m] you could open the Menu?..");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("We'll get it this time right? ;)");
                    Console.ReadLine();
                    Console.WriteLine("try again");
                    Console.ReadLine();
                    CheckMenu();
                    break;
            }

            return;
        }
        public void PrintMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("    press [b] to open your bag and check your items");
            Console.WriteLine("    press [g] to see how much gold you have;");
            Console.WriteLine("    press [s] to see your stats");
            Console.WriteLine("    press [q] to quit the game");
            Console.WriteLine("    press [r] to restart the game");
            Console.WriteLine("    [c] close the menu");
            var PrntMenu = Console.ReadLine();
            switch (PrntMenu.ToLower())
            {
                case "b":
                    Console.WriteLine("Bag: ");
                    Bag.PrintBag();
                    Console.ReadLine();
                    Console.Clear();
                    PrintMenu();
                    break;
                
                case "g":
                    Console.WriteLine("Money: " + Items._currentGold);
                    Console.ReadLine();
                    Console.Clear();
                    PrintMenu();
                    break;

                case "s":
                    Console.WriteLine("Stats");
                    Player.PrintStats();
                    Console.ReadLine();
                    Console.Clear();
                    PrintMenu();
                    break;

                case "q":
                    Console.WriteLine("You sure you want to quit? :(");
                    Oddday.QuitGame();
                    Console.ReadLine();
                    Console.Clear();
                    PrintMenu();
                    break;

                case "r":
                    Oddday.RestartGame();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "c":
                    Console.WriteLine("close menu");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Type again");
                    Console.ReadLine();
                    Console.Clear();
                    PrintMenu();
                    break;
            }
        }
        
        public void YouSure()
        {
            Console.WriteLine(Oddday.PlayerName + "You sure you want to? :(");
            Console.WriteLine("    Entry: [yes] or [no]");
            var YouSure = Console.ReadLine();
            switch (YouSure.ToLower())
            {
                case "yes":
                    break;
                case "no":
                    Menu.PrintMenu();
                    break;
                default:
                    Console.WriteLine("please one of these:    [yes] or [no]?");
                    break;
            }
        }

        
    }
}