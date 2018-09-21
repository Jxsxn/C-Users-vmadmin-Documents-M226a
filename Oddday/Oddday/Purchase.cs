using System;

namespace Oddday
{
    public class Purchase
    {
        public static void PurchaseShop()
        {
            Console.WriteLine("Choose between [food], [weapons] or [leave]");
            Console.ReadLine();
            Console.Clear();
            var PrchsShp = Console.ReadLine();
            switch (PrchsShp.ToLower())
            {
                case "food":
                    Console.WriteLine("Hello Customer!");
                    Console.WriteLine("Do you wanna buy something?");
                    break;
                case "weapons":
                    Console.WriteLine("Hello " + Oddday.PlayerRace + " How can I help you?");

                    break;

                case "leave":
                    Console.WriteLine(Oddday.PlayerName + "leaving bye!");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Select again");
                    PurchaseShop();
                    break;
            }

            return;
        }
    }
}