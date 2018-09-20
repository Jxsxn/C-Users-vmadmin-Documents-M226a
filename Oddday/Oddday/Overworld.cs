using System;

namespace Oddday
{
    public class Overworld
    {
        public static void TravelMode()
        {
            Console.WriteLine("Entry:    [Market], [Forest] or [House]");
            var TravelMode = Console.ReadLine();
            switch (TravelMode.ToLower())
            {
                case "market":
                    Market.MarketPlace();
                    break;
                case "forest":
                    Forest.ForestPlace();
                    break;
                default:
                    Console.WriteLine("stay were you are");
                    break;
            }
        }
    }
}