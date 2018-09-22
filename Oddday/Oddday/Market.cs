using System;
using System.Runtime.InteropServices;

namespace Oddday
{
    public class Market
    {
        public static void MarketPlace(Oddday oddday)
        {
            Console.WriteLine("You're at the market now!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(oddday.PlayerName1 + " hmmmm.. there's a Bazar");
            Purchase.PurchaseShop(oddday);
        }
    }
}