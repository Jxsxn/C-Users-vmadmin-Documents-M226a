using System;

namespace Oddday
{
    public class Menu
    {
        private Oddday oddday;
        private Items odddayItems;
        private Bag odddaybag;
        private Player odddayplayer;
        
        public void CheckMenu()
        {
            Console.Clear();
            Console.WriteLine(oddday.PlayerName1 + ":  Guess with [m] I can open the menu..");
            var ChckMenu = Console.ReadLine();
            switch (ChckMenu.ToLower())
            {
                case "m":
                    PrintMenu();
                    break;
                default:
                    Console.WriteLine(oddday.PlayerName1 +
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
                    odddaybag.PrintBag();
                    Console.ReadLine();
                    Console.Clear();
                    PrintMenu();
                    break;
                
                case "g":
                    Console.WriteLine("Money: " + odddayItems._currentGold);
                    Console.ReadLine();
                    Console.Clear();
                    PrintMenu();
                    break;

                case "s":
                    Console.WriteLine("Stats");
                    odddayplayer.PrintStats();
                    Console.ReadLine();
                    Console.Clear();
                    PrintMenu();
                    break;

                case "q":
                    Console.WriteLine("You sure you want to quit? :(");
                    oddday.QuitGame();
                    Console.ReadLine();
                    Console.Clear();
                    PrintMenu();
                    break;

                case "r":
                    oddday.RestartGame();
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
            Console.WriteLine(oddday.PlayerName1 + "You sure you want to? :(");
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

        
    }
}