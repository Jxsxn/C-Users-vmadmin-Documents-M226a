using System;

namespace Oddday
{
    public class Overworld
    {
        public static void Map()
        {
            Console.WriteLine("Select your next target:");
            Console.WriteLine("    Entry:    [Market], [Forest] or [House]");
            Console.ReadLine();
            Console.Clear();
            var TravelMode = Console.ReadLine();
            switch (TravelMode.ToLower())
            {
                case "market":
                    Market.MarketPlace();
                    break;
                case "forest":
                    Forest.ForestPlace();
                    break;
                case "home":
                    Console.WriteLine("Home sweet home");
                    Home.HomePlayer();
                    break;
                    
                default:
                    Console.WriteLine("Try again");
                    Map();
                    break;
            }
        }
    }
}