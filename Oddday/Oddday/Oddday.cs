using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Net.Mime;
using System.Windows.Forms;

namespace Oddday
{
    public class Oddday
    {
        public bool ShowMenu = false;
        public  string PlayerName;

        public  string PlayerRace;


        public void Start()
        {
            Console.WriteLine("Goodmorning... good morning.. eh..");
            Console.WriteLine("Please tell me your name:");
            PlayerName = Console.ReadLine();
            {
                if (PlayerName == "")
                {
                    Start();
                }
                else if (PlayerName == "Jasmin")
                {
                    Console.WriteLine("Hahahahahahahahahhahahahahahahahahhahahahahhahahahahahahahahahahhahahahahhaahhaahhaha");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("..");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("    ..What's so funny?..");
                    Console.ReadLine();
                    Console.Clear();
                }
                
            }
            Console.Clear();
            Console.WriteLine("I see.. " + PlayerName + " that's a great Name!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("So now " + PlayerName + " are you a warrior or magician?");
            Player.CheckEntryChar();
            Console.WriteLine("You wake up and feel ready to safe the day!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(PlayerName + ":  Oh Boy im so exited..");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(PlayerName + ":  Something feels odd about today..");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(PlayerName + ":  But first i need a healthy breakfast.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(PlayerName + ":  True hero's never skip breakfast!");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(
                "Before you go out to do whatever you wanna do i'll have to explain the game machanics..");
            Console.WriteLine("Well.. just press some random buttons everything else is pretty much self explaining");

            Console.ReadLine();
            Console.Clear();
            Menu.CheckMenu();
            Console.WriteLine(
                "So that was you menu.. not that much aight? but don't worry you can buy food in the marketplace");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Where do you wanna go?");
            Overworld.Map();
            
        }


        public void RestartGame()
        {
            Console.WriteLine("Restart");
            Console.ReadLine();
            Console.Clear();
            Start();
        }

        public void QuitGame()
        {
            Console.WriteLine("Hope you liked it!");
            Console.ReadLine();
            Console.Clear();
            Application.Exit();
        }

    }
}