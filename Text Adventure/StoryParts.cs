using System.Security.Cryptography.X509Certificates;
using Text_Adventure;

namespace StoryParts
{
    public class Parts
    {

        public static void Please()
        {
            Program.staggerText("if you can read this somethings working!");
        }
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_____ __ __ _____ ____  __    _____ _____ _____");
            Thread.Sleep(200);
            Console.WriteLine("||  | ||  | ||    ||  | ||    ||  | ||  | ||  |");
            Thread.Sleep(200);
            Console.WriteLine("||  | ||  | ||_   ||-/  ||    ||  | ||--| ||  |");
            Thread.Sleep(200);
            Console.WriteLine("||  | || /  ||    ||  | ||    ||  | ||  | ||  |");
            Thread.Sleep(200);
            Console.WriteLine("||__| ||/   ||___ ||  | ||___ ||__| ||  | ||__/");
            Thread.Sleep(100);
            Console.ResetColor();
            Thread.Sleep(100);
            Console.WriteLine("");
            Console.WriteLine("By GABRIEL TSIRCOU");
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("Narration are in (Parentheses), speech are in plaintext, with you in white and in different colors for different people...");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("...And options to pick from are in yellow and in [brackets].");
            Console.ResetColor();
            Console.WriteLine("Make sure you don't misspell anything, as it'll fail and you'll probably have to restart.");
            Console.WriteLine("(HINT: Make sure it's in all lowercase!)");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press [ENTER] to begin.");
        }
        public static void Intro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("NOW BOOTING: [MAIN STORY]");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.WriteLine("BEGINNING SIMULATION...");
            Program.staggerText("...", 500);
            Console.Clear();
            Console.WriteLine("(It's 1999, and it's your first day at the newly built Howard's Point Nuclear Fission Plant as Chief Engineer.)");
            Thread.Sleep(1000);
            Console.WriteLine("(You walk up to the center console and turn it on.)");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine("Please Enter Credentials:");
            Console.WriteLine();
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.WriteLine("(You don't remember your passkey. You try not to stress about it as it was given to you an hour ago, but you still feel bad.)");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("([CHECK] your pockets for notes, [ASK] someone for help, or [GUESS] and hope you get lucky.)");
            Console.ResetColor();
        }
        public static void InCheck()
        {
            Console.WriteLine("");
            Console.WriteLine("(You check the insides of your pockets, and find a note from your supervisor. It reads-)");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Congrats on getting the job, rook! If you need help signing in, just type in your birthday, you'll need to change it by the end of the week.");
            Console.ResetColor();
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("(You're not sure if they're asking you to change your passkey or your birthday, but you type it in and it miraculously works.)");
            Thread.Sleep(1000);
            Console.WriteLine("(You sit as the console boots up.)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("(Press [ENTER] to continue.)");
        }
        public static void InAsk()
        {
            Console.WriteLine();
            Console.WriteLine("(You call someone over to help you sign in to the console.)");
            Thread.Sleep(1000);
            Console.WriteLine("(A security officer walks over to your side.)");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Alright, what seems to be the issue?");
            Thread.Sleep(1000);
            Console.ResetColor();
            Console.WriteLine("I'm having trouble signing in to the center console.");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Ah, great, a sprout, (mumble mumble).");
            Thread.Sleep(1000);
            Console.WriteLine("Ugh, fine. I'll let you in on a little secret that goes around among the engineers here.");
            Thread.Sleep(1000);
            Console.WriteLine("If you just slam the underside of your desk, it'll instantly give you administer access over the entire plant.");
            Thread.Sleep(1000);
            Console.WriteLine("Now don't bother me again, I already have a bunch of stuff to do, and it's only the beginning of the day.");
            Thread.Sleep(1000);
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("(Press [ENTER] to continue.)");
            string input = Console.ReadLine();
            Console.ResetColor();
            if (input == "")
            {
                Console.WriteLine();
                Console.WriteLine("(As he walks away, you're left worried about how such a huge oversight can go unnoticed by upper management.)");
                Thread.Sleep(1000);
                Console.WriteLine("(He also implied that you weren't the first engineer at this dest, even though the plant hasen't been online for a month now.)");
                Thread.Sleep(1000);
                Console.WriteLine("(Either way, you reach under the desk and and try his advice.)");
                Thread.Sleep(1000);
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Console.WriteLine("SLAM!");
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.WriteLine("(As you look back up, you're shocked to see the security guard was right as the console boots up into administration mode.)");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("(Press [ENTER] to continue.)");
            } 
            else
            {
                Console.WriteLine();
                Console.WriteLine("(As he walks away, you're left worried about how such a huge oversight can go unnoticed by upper management.)");
                Thread.Sleep(1000);
                Console.WriteLine("(He also implied that you weren't the first engineer at this dest, even though the plant hasen't been online for a month now.)");
                Thread.Sleep(1000);
                Console.WriteLine("(Either way, you reach under the desk and and try his advice.)");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("SLAM!");
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.WriteLine("(As you look back up, you're shocked to see the security guard was right as the console boots up like normal.)");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("(Press [ENTER] to continue.");
            }
        }
        public static void InGuess()
        {
            Console.WriteLine();
            Console.WriteLine("my munchables are all i have");

        }
        //Normal Console Stuff
        public static void BootUpConsole()
        {
            if (Program.isAdmin == true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Program.staggerText("...", 500);
                Console.Beep();
                Console.Clear();
                Program.dataLine();
                Console.Beep();
                Console.WriteLine("     ________   ___    __   _______   _____   ___    __   ________");
                Thread.Sleep(100);
                Console.WriteLine("    //      /   //|    /   //          //     //|    /   //       ");
                Thread.Sleep(100);
                Console.WriteLine("   //======/   // |   /   //_____     //     // |   /   //__      ");
                Thread.Sleep(100);
                Console.WriteLine("  //      /   //  |  /          /    //     //  |  /   //         ");
                Thread.Sleep(100);
                Console.WriteLine(" //      /   //   | /          /    //     //   | /   //          ");
                Thread.Sleep(100);
                Console.WriteLine("//      /  _//_  _|/_   ______/  __//__  _//_  _|/_  //______     ");
                Console.WriteLine("ANSINE CORP.TM COPYRIGHT 1997");
                Thread.Sleep(100);
                Program.staggerText("...", 500);
                Console.WriteLine("");
                Console.WriteLine("WELCOME TO ANSINE CORP.TM REACTOR CONTROL CONSOLE, VER. 1.8.4");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ADMIN CONSOLE ACCESS GRANTED");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Thread.Sleep(300);
                Console.WriteLine("");
                Console.WriteLine("Please Select an Command:");
                Console.WriteLine("");
                Thread.Sleep(100);
                Console.WriteLine("[1] STARTUP SEQUENCE");
                Console.WriteLine("[2] REACTOR STATUS");
                Console.WriteLine("[3] NETWORK ACCESS");
                Console.WriteLine("[4] LOGS");
                Console.WriteLine("[5] EMERGENCY PROGRAMS");
                Console.WriteLine("[6] MANUAL");
                Console.WriteLine("[7] QUIT");
                Console.WriteLine();
                string input = Console.ReadLine();
                if (input == "1")
                {
                    reactorStartup();
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

                }
                else if (input == "6")
                {

                }
                else if (input == "7")
                {

                }
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.DarkGreen;
                Program.staggerText("...", 500);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Beep();
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Program.dataLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Beep();
                Console.WriteLine("     ________   ___    __   _______   _____   ___    __   ________");
                Thread.Sleep(100);
                Console.WriteLine("    //      /   //|    /   //          //     //|    /   //       ");
                Thread.Sleep(100);
                Console.WriteLine("   //======/   // |   /   //_____     //     // |   /   //__      ");
                Thread.Sleep(100);
                Console.WriteLine("  //      /   //  |  /          /    //     //  |  /   //         ");
                Thread.Sleep(100);
                Console.WriteLine(" //      /   //   | /          /    //     //   | /   //          ");
                Thread.Sleep(100);
                Console.WriteLine("//      /  _//_  _|/_   ______/  __//__  _//_  _|/_  //______     ");
                Console.WriteLine("ANSINE CORP.TM COPYRIGHT 1997");
                Thread.Sleep(100);
                Program.staggerText("...", 500);
                Console.WriteLine("");
                Console.WriteLine("WELCOME TO ANSINE CORP.TM REACTOR CONTROL CONSOLE, VER. 1.8.4");
                Thread.Sleep(300);
                Console.WriteLine("");
                Console.WriteLine("Please Select an Command:");
                Console.WriteLine("");
                Thread.Sleep(100);
                Console.WriteLine("[1] STARTUP SEQUENCE");
                Console.WriteLine("[2] REACTOR STATUS");
                Console.WriteLine("[3] LOGS");
                Console.WriteLine("[4] EMERGENCY PROGRAMS");
                Console.WriteLine("[5] MANUAL");
                Console.WriteLine("[6] QUIT");
                Console.WriteLine();
                string input = Console.ReadLine();
                if (input == "1")
                {
                    reactorStartup();
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

                }
                else if (input == "6")
                {

                }
                else if (input == "7")
                {

                }
            }
            
        }
        public static void ConsoleHome()
        {
            if (Program.isAdmin == true)
            {
                Console.Clear();
                Program.dataLine();
                Console.WriteLine("     ________   ___    __   _______   _____   ___    __   ________");
                Console.WriteLine("    //      /   //|    /   //          //     //|    /   //       ");
                Console.WriteLine("   //======/   // |   /   //_____     //     // |   /   //__      ");
                Console.WriteLine("  //      /   //  |  /          /    //     //  |  /   //         ");
                Console.WriteLine(" //      /   //   | /          /    //     //   | /   //          ");
                Console.WriteLine("//      /  _//_  _|/_   ______/  __//__  _//_  _|/_  //______     ");
                Console.WriteLine("ANSINE CORP.TM COPYRIGHT 1997");
                Thread.Sleep(10);
                Console.WriteLine("");
                Console.WriteLine("WELCOME TO ANSINE CORP.TM REACTOR CONTROL CONSOLE, VER. 1.8.4");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ADMIN CONSOLE ACCESS GRANTED");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Thread.Sleep(10);
                Console.WriteLine("");
                Console.WriteLine("Please Select an Command:");
                Console.WriteLine("");
                Thread.Sleep(10);
                Console.WriteLine("[1] STARTUP SEQUENCE");
                Console.WriteLine("[2] REACTOR STATUS");
                Console.WriteLine("[3] NETWORK ACCESS");
                Console.WriteLine("[4] LOGS");
                Console.WriteLine("[5] EMERGENCY PROGRAMS");
                Console.WriteLine("[6] MANUAL");
                Console.WriteLine("[7] QUIT");
                Console.WriteLine();
                string input = Console.ReadLine();
                if (input == "1")
                {
                    reactorStartup();
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

                }
                else if (input == "6")
                {

                }
                else if (input == "7")
                {

                }
            }
            else
            {
                Console.Clear();
                Program.dataLine();
                Console.WriteLine("     ________   ___    __   _______   _____   ___    __   ________");
                Console.WriteLine("    //      /   //|    /   //          //     //|    /   //       ");
                Console.WriteLine("   //======/   // |   /   //_____     //     // |   /   //__      ");
                Console.WriteLine("  //      /   //  |  /          /    //     //  |  /   //         ");
                Console.WriteLine(" //      /   //   | /          /    //     //   | /   //          ");
                Console.WriteLine("//      /  _//_  _|/_   ______/  __//__  _//_  _|/_  //______     ");
                Console.WriteLine("ANSINE CORP.TM COPYRIGHT 1997");
                Thread.Sleep(10);
                Console.WriteLine("");
                Console.WriteLine("WELCOME TO ANSINE CORP.TM REACTOR CONTROL CONSOLE, VER. 1.8.4");
                Thread.Sleep(10);
                Console.WriteLine("");
                Console.WriteLine("Please Select an Command:");
                Console.WriteLine("");
                Thread.Sleep(10);
                Console.WriteLine("[1] STARTUP SEQUENCE");
                Console.WriteLine("[2] REACTOR STATUS");
                Console.WriteLine("[3] NETWORK ACCESS");
                Console.WriteLine("[4] LOGS");
                Console.WriteLine("[5] EMERGENCY PROGRAMS");
                Console.WriteLine("[6] MANUAL");
                Console.WriteLine("[7] QUIT");
                Console.WriteLine();
                string input = Console.ReadLine();
                if (input == "1")
                {
                    reactorStartup();
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

                }
                else if (input == "6")
                {

                }
                else if (input == "7")
                {

                }
            }
            
        }
        public static void reactorStartup()
        {
            Console.Clear();
            Program.dataLine();
            Console.WriteLine();
            Console.Write("REACTOR STATUS: ");
            if (Program.reactorStarted == false)
            {
                Program.staggerText("...", 500);
                Console.Clear();
                Program.dataLine();
                Console.WriteLine();
                Console.Write("REACTOR STATUS: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("OFFLINE");
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.DarkGreen;
                Console.WriteLine("Reactor is Offline. Automatic Restart Ready.");
                Console.WriteLine("Please Consult Manual for Instructions.");
                Console.WriteLine();
                Console.WriteLine("Please select a Command:");
                Console.WriteLine();
                Console.WriteLine("[1] STARTUP REACTOR");
                Console.WriteLine("[2] BACK TO MAIN MENU");
                Console.WriteLine("[3] QUIT");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.Clear();
                    Program.dataLine();
                    Console.WriteLine();
                    Console.Write("INITIATING AUTOMATIC REACTOR STARTUP");
                    Program.staggerText("......", 500);
                    Console.WriteLine("Engaging Generator Lines");
                    Program.staggerText("........", 500);
                    Console.WriteLine("Inserting Thorium Fuel Rods");
                    Program.coreTemp += 200;
                    Console.Clear();
                    Program.dataLine();
                    Console.WriteLine();
                    Console.WriteLine("INITIATING AUTOMATIC REACTOR STARTUP......");
                    Console.WriteLine("Engaging Generator Lines........");
                    Console.WriteLine("Inserting Thorium Fuel Rods");
                    Program.staggerText(".....");
                    Console.WriteLine("Engaging Failsafe Measures");
                    Program.staggerText("....");
                    Console.WriteLine("Opening Steam Circulation Valves");
                    Program.coreTemp += 50;
                    Console.Clear();
                    Program.dataLine();
                    Console.WriteLine();
                    Console.WriteLine("INITIATING AUTOMATIC REACTOR STARTUP......");
                    Console.WriteLine("Engaging Generator Lines........");
                    Console.WriteLine("Inserting Thorium Fuel Rods.....");
                    Console.WriteLine("Engaging Failsafe Measures....");
                    Console.WriteLine("Opening Steam Circulation Valves");
                    Program.staggerText(".....");
                    Console.WriteLine("Inserting Plutonium Neutron Source");
                    Program.coreTemp += 100;
                    Console.Clear();
                    Program.dataLine();
                    Console.WriteLine();
                    Console.WriteLine("INITIATING AUTOMATIC REACTOR STARTUP......");
                    Console.WriteLine("Engaging Generator Lines........");
                    Console.WriteLine("Inserting Thorium Fuel Rods.....");
                    Console.WriteLine("Engaging Failsafe Measures....");
                    Console.WriteLine("Opening Steam Circulation Valves.....");
                    Console.WriteLine("Inserting Plutonium Neutron Source");
                    Program.staggerText("...");
                    Console.WriteLine("Disengaging Fission Reaction Limiters");
                    Program.coreTemp += 150;
                    Console.Clear();
                    Program.dataLine();
                    Console.WriteLine();
                    Console.WriteLine("INITIATING AUTOMATIC REACTOR STARTUP......");
                    Console.WriteLine("Engaging Generator Lines........");
                    Console.WriteLine("Inserting Thorium Fuel Rods.....");
                    Console.WriteLine("Engaging Failsafe Measures....");
                    Console.WriteLine("Opening Steam Circulation Valves.....");
                    Console.WriteLine("Inserting Plutonium Neutron Source...");
                    Console.WriteLine("Disengaging Fission Reaction Limiters");
                    Program.staggerText("..");
                    Console.WriteLine("Reading Reaction Sensors");
                    Thread.Sleep(230);
                    //standard temp 520C
                }
                else if (input == "2")
                {
                    ConsoleHome();
                }
                else if (input == "3")
                {

                }
            }
        }
    }
}