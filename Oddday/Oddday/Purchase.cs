using System;

namespace Oddday
{
    public class Purchase
    {
        public static void PurchaseShop(Oddday oddday)
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
                    Console.WriteLine("Hello " + oddday.PlayerRace1 + " How can I help you?");
                    break;
                
                case "leave":
                    Console.WriteLine(oddday.PlayerName1 + "leaving bye!");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                
                default:
                    Console.WriteLine("Select again");
                    PurchaseShop(oddday);
                    break;
            }
        }
    }
}