using System;
using System.IO;

namespace Oddday
{
    public class Food
    {
        public static void PrintFood()
        {
            var PrntFood = Console.ReadLine();
            switch (PrntFood.ToLower())
            {
                case "apple":
                    Console.WriteLine("How many Apples do you want?");
                    HowMuch();
                    PrintFood();
                    break;
                case "bread":
                    Console.WriteLine("How many Bread do you want?");
                    HowMuch();
                    PrintFood();
                    break;
                case "Meat":
                    Console.WriteLine("How many Meat do you want?");
                    HowMuch();
                    PrintFood();
                    break;
                case "nothing":
                    Console.WriteLine("So you don't want anything?");
                    Menu.YouSure();
                    break;
                default:
                    Console.WriteLine("I don't understand");
                    Console.ReadLine();
                    PrintFood();
                    break;
            }

         
        }

        public static void HowMuch()
        {
            Console.WriteLine("Entry a number: ");
            Console.WriteLine("Or don't buy anything []");
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 0:
                    Console.WriteLine("You wanna buy " + num + " of these?");
                    Menu.YouSure();
                    break;

                default:
                    Console.WriteLine("You don't want those?");
                    Menu.YouSure();
                    Console.WriteLine("Ok");
                    Console.ReadLine();
                    break;
              
            }

        }
    }
}