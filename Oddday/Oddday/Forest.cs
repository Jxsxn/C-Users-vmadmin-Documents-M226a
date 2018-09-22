using System;
using System.Runtime.InteropServices;

namespace Oddday
{
    public class Forest
    {
        public static void ForestPlace(Oddday oddday)
        {
            Console.WriteLine("You're at the forest now!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(oddday.PlayerName1 + " hmmmm.. ");
            Console.WriteLine("The air you breath is thin and cold.. maybe you shouldn't be here for now..");
            Console.ReadLine();
            Console.Clear();
            
        }
    }
}