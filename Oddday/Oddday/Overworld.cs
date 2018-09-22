using System;

namespace Oddday
{
    public class Overworld
    {
        public void Map(Oddday oddday)
        {
            Console.WriteLine("Select your next target:");
            Console.WriteLine("    Entry:    [Market], [Forest] or [House]");
            Console.ReadLine();
            Console.Clear();
            var TravelMode = Console.ReadLine();
            switch (TravelMode.ToLower())
            {
                case "market":
                    Market.MarketPlace(oddday);
                    break;
                case "forest":
                    Forest.ForestPlace(oddday);
                    break;
                case "home":
                    Console.WriteLine("Home sweet home");
                    Home.HomePlayer(oddday);
                    break;
                    
                default:
                    Console.WriteLine("Try again");
                    Map();
                    break;
            }
        }
    }
}