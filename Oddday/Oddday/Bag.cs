using System;

namespace Oddday
{
    public class Bag
    {
        Bag[] BagArray = new Bag[10];
        public static void PrintBag()
        {
            Console.WriteLine("Bag:    ");
            Items.PrintItems();
            
        }
    }
}