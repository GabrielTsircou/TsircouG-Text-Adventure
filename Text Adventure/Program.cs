using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Timers;

namespace Text_Adventure
{
    public class Program
    {
        public static void staggerText(string text, int staggerTime = 100)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(staggerTime);
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ___  __  ____ ___");
            Thread.Sleep(100);
            Console.WriteLine("||  |/  |  ||  |  |");
            Thread.Sleep(100);
            Console.WriteLine("||  |   |  ||  |  |");
            Thread.Sleep(100);
            Console.WriteLine("||  |   |  ||  |  |");
            Thread.Sleep(100);
            Console.WriteLine("||  |   | _||_ |__/");
            Thread.Sleep(100);
            Console.ResetColor();
            Thread.Sleep(100);
            Console.WriteLine("");
            Console.WriteLine("By GABRIEL TSIRCOU");
            Console.WriteLine("");
            Thread.Sleep(100);
            Console.WriteLine("Options to pick from are in [square brackets], narration are in (parentheses), and speech are in plaintext...");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("...And other characters's speech are in a different color");
            Console.ResetColor();
            Console.WriteLine("Make sure you don't misspell anything, as it'll fail and you'll probably have to restart.");
            Console.WriteLine("(HINT: Make sure it's in all lowercase!)");
            Console.WriteLine("");
            Console.WriteLine("[MAIN STORY] or [DEBUG]");
            //makes input from the console readable
            string input = Console.ReadLine();
            //spits out the input
            Console.Clear();
            if (input == "main story")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            Console.WriteLine("NOW BOOTING: [" + input.ToUpper() + "]");

            if (input == "debug")
            {
                Console.ResetColor();
                Console.WriteLine("BOOTING UP TEST SIMULATION...");
                Console.WriteLine("please work");
                Console.WriteLine("[RECOLOR] or [WAIT] or [BRANCH]");
                input = Console.ReadLine();

                //if (input == "TIMER") { }
                //{
                //System.Timers.Timer Timer = new System.Timers.Timer();
                // }
                if (input == "RECOLOR")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("yooooo shits red now");
                    Console.ResetColor();
                    Console.WriteLine("back to normal now");
                }
                else if (input == "ALL CAPS!")
                {
                    Console.WriteLine("its supposed to load the music video for MF DOOM's ''All Caps'' lol");
                }
                else if (input == "WAIT")
                {
                    Thread.Sleep(5000);
                    Console.WriteLine("You wasted 5 seconds");
                    staggerText("...", 1000);

                }
                else if (input == "BRANCH")
                {
                    Console.WriteLine("[3] or [4] or [even more]");
                    input = Console.ReadLine();
                    if (input == "3")
                    {
                        Console.WriteLine("boooo");
                    }
                    else if (input == "4")
                    {
                        Console.WriteLine("why cant i write functional code");
                    }
                    else if (input == "even more")
                    {
                        Console.WriteLine("[5] or [6]");
                        input = Console.ReadLine();
                        if (input == "5")
                        {
                            Console.WriteLine("please let the nightmare end");
                        }
                        else if (input == "6")
                        {
                            Console.WriteLine("please let me die");
                        }
                        else
                        {
                            Console.WriteLine("GRAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
                        }
                    }
                    else
                    {
                        Console.WriteLine("WRONG ANSWER *POW!* *POW!* *POW!* *POW!* *POW!* *POW!* *POW!* *POW!* *reload* *POW!* *POW!* *POW!* *POW!* *POW!* *P");
                    }
                }
                else
                {
                    Console.WriteLine("BOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
                }
            }
            else if (input == "main story")
            {
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.WriteLine("BEGINNING SIMULATION...");
                staggerText("...", 500);
                Thread.Sleep(500);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Beep();
                Console.WriteLine("     ________   ___    __   _______  _____   ___    __   ________");
                Thread.Sleep(100);
                Console.WriteLine("    //      /   //|    /   //         //     //|    /   //");
                Thread.Sleep(100);
                Console.WriteLine("   //======/   // |   /   //_____    //     // |   /   //__");
                Thread.Sleep(100);
                Console.WriteLine("  //      /   //  |  /         /    //     //  |  /   //   ");
                Thread.Sleep(100);
                Console.WriteLine(" //      /   //   | /         /    //     //   | /   //");
                Thread.Sleep(100);
                Console.WriteLine("//      /  _//_  _|/_  ______/  __//__  _//_  _|/_  //______");
                Console.WriteLine("ANSINE CORP.TM COPYRIGHT 1997");
                Thread.Sleep(100);
                staggerText("...", 500);
                Console.WriteLine("");
                Console.WriteLine("WELCOME TO ANSINE CORP.TM REACTOR CONTROL CONSOLE, VER. 1.8.4");
                Thread.Sleep(300);
                Console.WriteLine("");
                Console.WriteLine("Please Select an Command:");
                
            }
            else
            {
                Console.WriteLine("haha you messed up have fun reloading the program");
            }
        }
    }
}

