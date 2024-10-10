using StoryParts;

namespace Text_Adventure
{
    public class Program
    {
        public static bool isAdmin = false;
        public static bool reactorStarted = false;
        public static bool reactorStatus = false;
        public static float coreTemp = 22;
        public static string date = "June 28, 1999";
        public static string time = "09:38";
        public static void staggerText(string text, int staggerTime = 100)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(staggerTime);
            }
            Console.WriteLine();
        }
        public static void dataLine()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("DATE: " + date + " CURRENT TIME: " + time + " REACTOR TEMP: " + coreTemp + "C COPYRIGHT ANSINE CORP.TM 1997");
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