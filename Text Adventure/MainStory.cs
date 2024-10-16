using StoryParts;
//my munchables are all i have
namespace Text_Adventure
{
    public class Program
    {
        enum tempStatus
        {
            Black,
            Blue,
            DarkGreen,
            Yellow,
            Red
        }
        public static bool isAdmin = false;
        public static int reactorStarted = 0;
        public static bool reactorStatus = false;
        public static double coreTemp = 22;
        public static double coreRise = 0.5;
        public static string date = "28 June, 1999";
        public static int hour = 09;
        public static int minute = 38;
        private static int tempNum;

        public static Thread thread = new(() =>
        {
            while (true)
            {
                coreTemp += coreRise;
                Thread.Sleep(100);
            }
        });

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
                Parts.ReactorStatus();
            }
            else if (input == "3")
            {
                Parts.ReactorLogs();
            }
            else if (input == "4")
            {
                Parts.EmergencyPrograms();
            }
            else if (input == "5")
            {
                Parts.ReactorManual();
            }
            else if (input == "6")
            {

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please Enter a Valid Command.");
                Console.WriteLine("(Press [ENTER] to Continue.)");
                input = Console.ReadLine();
                if (input == "")
                {
                    Parts.ConsoleHome();
                }
                else
                {
                    Parts.ConsoleHome();
                }
            }
        }
        public static void DataLine()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("DATE: " + date);
            Console.Write(" TIME: " + hour.ToString() + ":" + minute.ToString());
            Console.Write(" CORE TEMP: ");
            if (coreTemp >= 100)
            {
                Console.ForegroundColor = (ConsoleColor)tempStatus.Blue;
            }
            if (coreTemp >= 500)
            {
                Console.ForegroundColor = (ConsoleColor)tempStatus.DarkGreen;
            }
            if (coreTemp >= 600)
            {
                Console.ForegroundColor = (ConsoleColor)tempStatus.Yellow;
            }
            if (coreTemp > 700)
            {
                Console.ForegroundColor = (ConsoleColor)tempStatus.Red;
            }
            Console.Write((int)coreTemp + "C");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" COPYRIGHT ANSINE CORP.TM 1997");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public static void Main(string[] args)
        {

            Console.SetWindowSize(175, 30);
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
                
                }
            }
        }
    }
