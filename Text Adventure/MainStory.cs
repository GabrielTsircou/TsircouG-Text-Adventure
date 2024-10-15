﻿using StoryParts;

namespace Text_Adventure
{
    public class Program
    {
        public static bool isAdmin = false;
        public static bool reactorStarted = false;
        public static bool reactorStatus = false;
        public static float coreTemp = 22;
        public static string date = "28 June, 1999";
        public static int hour = 09;
        public static int minute = 38;
        public static void staggerText(string text, int staggerTime = 500)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(staggerTime);
            }
            Console.WriteLine();
        }
        public static void Menu()
        {
            string input = Console.ReadLine();
            if (input == "1")
            {
                Parts.ReactorStartup();
            }
            else if (input == "2")
            {

            }
            else if (input == "3")
            {

            }
            else if (input == "4")
            {

            }
            else if (input == "5")
            {
                Parts.ReactorManual();
            }
            else if (input == "6")
            {

            }
        }
        public static void DataLine()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("DATE: " + date + " CURRENT TIME: " + hour.ToString() + ":" + minute.ToString() + " REACTOR TEMP: " + coreTemp + "(C) COPYRIGHT ANSINE CORP.TM 1997");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public static void Main(string[] args)
        {
            Console.SetWindowSize(150, 30);
            Parts.Start();
            //makes input from the console readable
            string input = Console.ReadLine();
            //spits out the input
            if (input == "DEBUG")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("NOW BOOTING: [DEBUG]");
                Console.ResetColor();
                staggerText("...", 500);
                Console.WriteLine("BOOTING UP TEST SIMULATION...");
                staggerText("...", 500);
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("[CMD] to load console, [JUMP] to jump to any point");
                Console.WriteLine("Please Enter Debug Command:");
                input = Console.ReadLine();
                if (input == "CMD")
                {
                    Console.WriteLine("isAdmin?");
                    input = Console.ReadLine();
                    if (input == "true")
                    {
                        isAdmin = true;
                        Console.WriteLine("Bootup?");
                        input = Console.ReadLine();
                        if (input == "true")
                        {
                            Parts.BootUpConsole();
                        }
                        else if (input == "false")
                        {
                            Parts.ConsoleHome();
                         
                        }
                    }
                    else if (input == "false")
                    {
                        Console.WriteLine("Bootup?");
                        input = Console.ReadLine();
                        if (input == "true")
                        {
                            Parts.BootUpConsole();
                        }
                        else if (input == "false")
                        {
                            Parts.ConsoleHome();
                        }
                    }
                    
                    

                }
            }
            else
            {
                Parts.Intro();
                input = Console.ReadLine();
                if (input == "check")
                {
                    Parts.InCheck();
                    input = Console.ReadLine();
                    if (input == "")
                    {
                        Parts.BootUpConsole();
                    }
                    else
                    {
                        Parts.BootUpConsole();
                    }
                }
                else if (input == "ask")
                {
                    Parts.InAsk();
                    isAdmin = true;
                    input = Console.ReadLine();
                    if (input == "")
                    {
                        Parts.BootUpConsole();
                    }
                    else
                    {
                        Parts.BootUpConsole();
                    }
                }
                else if (input == "guess")
                {
                    Parts.InGuess();
                }
            }
        }
    }
}