using System;
using System.Runtime.CompilerServices;

namespace Oddday
{
    public class Home
    {
        public static void HomePlayer(Oddday oddday)
        {
            Console.WriteLine("You're home now!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(oddday.PlayerName1 + ": I think i forgot the chicken..");
            Console.ReadLine();
            Console.Clear();
            Chicken(oddday);
        }

        private static void Chicken(Oddday oddday)
        {
            Console.Clear();
            Console.WriteLine("Want to take a look at the chicken?");
            Console.WriteLine("    Entry: [yes] or [no]");
            var Chckn = Console.ReadLine();
            switch (Chckn.ToLower())
            {
                case "yes":
                    Console.Clear();
                    Console.WriteLine("Mama mia looks like im right in time.. a minute later and i'd have to trough it away");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("You gain exp..");

                    break;
                case "no":
                    Console.Clear();
                    Console.WriteLine("hmmpf...");
                    Console.WriteLine("The Chicken will remember this");
                    break;
                default:
                    Console.WriteLine("You cant decide so you let it exist in a superposition");
                    Console.WriteLine("The space-time-continuum has stopped working.. " + oddday.PlayerName1 + " look what you've done!!");
                    oddday.RestartGame(oddday);
                    break;
            }
        }
    }
}