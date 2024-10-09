using StoryParts;

namespace Text_Adventure
{
    public class Program
    {
        public static bool isAdmin = false;
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
                Console.WriteLine("please work");
                Console.WriteLine("[RECOLOR] or [CALL] or [WAIT] or [BRANCH]");
                input = Console.ReadLine();

                if (input == "RECOLOR")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("yooooo shits red now");
                    Console.ResetColor();
                    Console.WriteLine("back to normal now");
                }
                else if (input == "CALL")
                {
                    Parts.Please();
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
                        input = Console.ReadLine();
                    }
                    else
                    {
                        Parts.BootUpConsole();
                        input = Console.ReadLine();
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