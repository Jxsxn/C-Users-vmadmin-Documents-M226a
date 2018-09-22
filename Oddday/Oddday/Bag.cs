using System;
using System.Data.Odbc;

namespace Oddday
{
    public class Bag
    {
        public Bag()
        {
            
        }
        Bag[] BagArray = new Bag[10];
        public void PrintBag(Oddday oddday)
        {
            Console.WriteLine("Bag:    ");
            //Items.PrintItems(oddday);
            
        }
    }
}