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
            Console.WriteLine("By TYLER, THE DESTROYER");
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("So some of this stuff isn't completely finished so i could get something playable out of this.");
            Console.WriteLine("This is because it's in early access and we need time to create something we love or some other bullcrap made up by AAA execs to make money off an incomplete game");
            Console.WriteLine("and totally not me procrastinating this entire project ehehe");
            Console.WriteLine("I'll tell you the parts that aren't complete so you can avoid them. Choices are in brackets btw, and make sure they're in all lowercase.");
            Console.WriteLine("also i forgot to add an actual way to die so just do the anti resonance option in emergency commands to see something actually happen");
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
            Console.WriteLine("([CHECK] your pockets for notes, [ASK] someone for help, or [GUESS (oops! theres isnt anything here)] and hope you get lucky.)");
            Console.ResetColor();
            Console.WriteLine();
            string input = Console.ReadLine();
            if (input == "check")
            {
                InCheck();
                input = Console.ReadLine();
                if (input == "")
                {
                    BootUpConsole();
                }
                else
                {
                    BootUpConsole();
                }
            }
            else if (input == "ask")
            {
                InAsk();
                Program.isAdmin = true;
                input = Console.ReadLine();
                if (input == "")
                {
                    BootUpConsole();
                }
                else
                {
                    BootUpConsole();
                }
            }
            else if (input == "guess")
            {
                InGuess();
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR: INVALID INPUT]");
                Console.WriteLine("[PRESS [ENTER] TO RETRY]");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                input = Console.ReadLine();
                if (input == "")
                {
                    Intro();
                }
                else
                {
                    Intro();
                }
            }
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("(Press [ENTER] to continue.)");
            string input = Console.ReadLine();
            Console.ResetColor();
            if (input == "")
            {
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
                Program.DataLine();
                Console.WriteLine();
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
                Console.WriteLine("//      /  _//_  _|/_   ______/  __//__  _//_  _|/_  //______ TM");
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
                Console.WriteLine("[2] REACTOR STATUS (not available)");
                Console.WriteLine("[3] LOGS (not avalable either dang)");
                Console.WriteLine("[4] EMERGENCY PROGRAMS");
                Console.WriteLine("[5] MANUAL");
                Console.WriteLine("[6] QUIT");
                Console.WriteLine();
                Program.Menu();

            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Program.staggerText("...", 500);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Beep();
                Console.Clear();
                Program.DataLine();
                Console.WriteLine();
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
                Console.WriteLine("//      /  _//_  _|/_   ______/  __//__  _//_  _|/_  //______ TM");
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
                Console.WriteLine("[2] REACTOR STATUS (not available)");
                Console.WriteLine("[3] LOGS (not available either dang)");
                Console.WriteLine("[4] EMERGENCY PROGRAMS");
                Console.WriteLine("[5] MANUAL");
                Console.WriteLine("[6] QUIT");
                Console.WriteLine();
                Program.Menu();

            }

        }
        public static void ConsoleHome()
        {
            if (Program.isAdmin == true)
            {
                Console.Clear();
                Program.DataLine();
                Console.WriteLine();
                Console.WriteLine("     ________   ___    __   _______   _____   ___    __   ________");
                Console.WriteLine("    //      /   //|    /   //          //     //|    /   //       ");
                Console.WriteLine("   //======/   // |   /   //_____     //     // |   /   //__      ");
                Console.WriteLine("  //      /   //  |  /          /    //     //  |  /   //         ");
                Console.WriteLine(" //      /   //   | /          /    //     //   | /   //          ");
                Console.WriteLine("//      /  _//_  _|/_   ______/  __//__  _//_  _|/_  //______ TM");
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
                Console.WriteLine("[2] REACTOR STATUS (not available)");
                Console.WriteLine("[3] LOGS (not available either oops)");
                Console.WriteLine("[4] EMERGENCY PROGRAMS");
                Console.WriteLine("[5] MANUAL");
                Console.WriteLine("[6] QUIT");
                Console.WriteLine();
                Program.Menu();
            }
            else
            {
                Console.Clear();
                Program.DataLine();
                Console.WriteLine();
                Console.WriteLine("     ________   ___    __   _______   _____   ___    __   ________");
                Console.WriteLine("    //      /   //|    /   //          //     //|    /   //       ");
                Console.WriteLine("   //======/   // |   /   //_____     //     // |   /   //__      ");
                Console.WriteLine("  //      /   //  |  /          /    //     //  |  /   //         ");
                Console.WriteLine(" //      /   //   | /          /    //     //   | /   //          ");
                Console.WriteLine("//      /  _//_  _|/_   ______/  __//__  _//_  _|/_  //______ TM");
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
                Console.WriteLine("[2] REACTOR STATUS (not available)");
                Console.WriteLine("[3] LOGS (not available either dang");
                Console.WriteLine("[4] EMERGENCY PROGRAMS");
                Console.WriteLine("[5] MANUAL");
                Console.WriteLine("[6] QUIT");
                Console.WriteLine();
                Program.Menu();
            }

        }
        public static void ReactorStartup()
        {
            Console.Clear();
            Program.DataLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("REACTOR STATUS: ");
            if (Program.reactorStarted == 0)
            {
                Program.staggerText("...", 500);
                Console.Clear();
                Program.DataLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("REACTOR STATUS: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("OFFLINE");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Reactor is Offline. Automatic Restart Ready.");
                Console.WriteLine("Please Consult Manual for Instructions.");
                Console.WriteLine();
                Console.WriteLine("Please select a Command:");
                Console.WriteLine();
                Console.WriteLine("[1] STARTUP REACTOR");
                Console.WriteLine("[2] BACK");
                Console.WriteLine();
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.Clear();
                    Program.DataLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("INITIATING AUTOMATIC REACTOR STARTUP");
                    Program.staggerText("......", 500);
                    Console.WriteLine();
                    Console.Write("Engaging Generator Lines");
                    Program.staggerText("........", 500);
                    Console.WriteLine();
                    Console.Write("Inserting Uranium Fuel Rods");
                    Program.coreTemp += 200;
                    Program.minute += 2;
                    Console.Clear();
                    Program.DataLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("INITIATING AUTOMATIC REACTOR STARTUP......");
                    Console.WriteLine();
                    Console.WriteLine("Engaging Generator Lines........");
                    Console.WriteLine();
                    Console.Write("Inserting Uranium Fuel Rods");
                    Program.staggerText(".....");
                    Console.WriteLine();
                    Console.Write("Engaging Failsafe Measures");
                    Program.staggerText("....");
                    Console.WriteLine("Opening Steam Circulation Valves");
                    Program.coreTemp += 50;
                    Program.minute += 2;
                    Console.Clear();
                    Program.DataLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("INITIATING AUTOMATIC REACTOR STARTUP......");
                    Console.WriteLine();
                    Console.WriteLine("Engaging Generator Lines........");
                    Console.WriteLine();
                    Console.WriteLine("Inserting Uranium Fuel Rods.....");
                    Console.WriteLine();
                    Console.WriteLine("Engaging Failsafe Measures....");
                    Console.WriteLine();
                    Console.Write("Opening Steam Circulation Valves");
                    Program.staggerText(".....");
                    Console.WriteLine("Inserting Plutonium Neutron Source");
                    Program.coreTemp += 100;
                    Program.minute += 6;
                    Console.Clear();
                    Program.DataLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("INITIATING AUTOMATIC REACTOR STARTUP......");
                    Console.WriteLine();
                    Console.WriteLine("Engaging Generator Lines........");
                    Console.WriteLine();
                    Console.WriteLine("Inserting Uranium Fuel Rods.....");
                    Console.WriteLine();
                    Console.WriteLine("Engaging Failsafe Measures....");
                    Console.WriteLine();
                    Console.WriteLine("Opening Steam Circulation Valves.....");
                    Console.WriteLine();
                    Console.Write("Inserting Plutonium Neutron Source");
                    Program.staggerText("...");
                    Console.WriteLine("Disengaging Fission Reaction Limiters");
                    Program.coreTemp += 150;
                    Program.minute += 3;
                    Console.Clear();
                    Program.DataLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("INITIATING AUTOMATIC REACTOR STARTUP......");
                    Console.WriteLine();
                    Console.WriteLine("Engaging Generator Lines........");
                    Console.WriteLine();
                    Console.WriteLine("Inserting Uranium Fuel Rods.....");
                    Console.WriteLine();
                    Console.WriteLine("Engaging Failsafe Measures....");
                    Console.WriteLine();
                    Console.WriteLine("Opening Steam Circulation Valves.....");
                    Console.WriteLine();
                    Console.WriteLine("Inserting Plutonium Neutron Source...");
                    Console.WriteLine();
                    Console.Write("Disengaging Fission Reaction Limiters");
                    Program.staggerText("..");
                    Console.WriteLine();
                    Console.WriteLine("Reading Reaction Sensors");
                    Thread.Sleep(230);
                    Program.reactorStarted++;
                    Program.thread.Start();
                    Program.minute += 7;
                    Console.Clear();
                    Program.DataLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("INITIATING AUTOMATIC REACTOR STARTUP......");
                    Console.WriteLine();
                    Console.WriteLine("Engaging Generator Lines........");
                    Console.WriteLine();
                    Console.WriteLine("Inserting Uranium Fuel Rods.....");
                    Console.WriteLine();
                    Console.WriteLine("Engaging Failsafe Measures....");
                    Console.WriteLine();
                    Console.WriteLine("Opening Steam Circulation Valves.....");
                    Console.WriteLine();
                    Console.WriteLine("Inserting Plutonium Neutron Source...");
                    Console.WriteLine();
                    Console.WriteLine("Disengaging Fission Reaction Limiters..");
                    Console.WriteLine();
                    Console.WriteLine("Reading Reaction Sensors");
                    Console.WriteLine();
                    Console.WriteLine("REACTOR ONLINE AND OPERATIONAL");
                    Console.WriteLine("ALL SYSTEMS NOMINAL");
                    Console.WriteLine();
                    Console.WriteLine("Press [ENTER] to Exit.");
                    Console.WriteLine();
                    input = Console.ReadLine();
                    if (input == "")
                    {
                        ReactorStartup();
                    }
                    else
                    {
                        ReactorStartup();
                    }
                    //standard temp 520C
                }
                else if (input == "2")
                {
                    ConsoleHome();

                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Command.");
                    Console.WriteLine("(Press [ENTER] to Continue.)");
                    input = Console.ReadLine();
                    if (input == "")
                    {
                        Parts.ReactorStartup();
                    }
                    else
                    {
                        Parts.ReactorStartup();
                    }
                }
            }
            if (Program.reactorStarted == 1)
            {
                Program.staggerText("...", 500);
                Console.Clear();
                Program.DataLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("REACTOR STATUS: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("ONLINE");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Reactor is Online. All Systems Nominal.");
                Console.WriteLine("Check REACTOR STATUS for Detailed Status.");
                Console.WriteLine("Please Consult Manual for More Information.");
                Console.WriteLine();
                Console.WriteLine("Please Select a Command");
                Console.WriteLine();
                Console.WriteLine("[1] SHUTDOWN REACTOR");
                Console.WriteLine("[2] QUIT");
                Console.WriteLine();
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("uhhhhh you werent supposed to do that");
                }
                else if (input == "2")
                {
                    ConsoleHome();
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Command.");
                    Console.WriteLine("(Press [ENTER] to Continue.)");
                    input = Console.ReadLine();
                    if (input == "")
                    {
                        Parts.ReactorStartup();
                    }
                    else
                    {
                        Parts.ReactorStartup();
                    }
                }
            }
        }
        public static void EmergencyPrograms()
        {
            Console.Clear();
            Program.DataLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("EMERGENCY PROCEDURES");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Please Select a Command:");
            Console.WriteLine();
            Console.WriteLine("[ENGAGE] Control Rods");
            Console.WriteLine("[VENT] into Atmosphere");
            Console.WriteLine("[DUMP] Core Contents");
            Console.WriteLine("[BACK]");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Engage [ANTI RESONANCE] Emitters");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string input = Console.ReadLine();
            //should set core rise to a smaller/negative number to cool reactor
            if (input == "engage")
            {

            }
            else if (input == "vent")
            {

            }
            //sets reactorStarted to zero
            else if (input == "dump")
            {
                Console.WriteLine();
                Console.Write("Engaging Failsafe Locks");
                Program.staggerText("...");
                Console.WriteLine();
                Console.Write("Opening Core Valves");
                Program.staggerText(".....");
                Program.coreTemp = 250;
                Program.reactorStarted--;
                Console.Clear();
                Program.DataLine();
                Console.WriteLine();
                Console.WriteLine("Engaging Failsafe Locks...");
                Console.WriteLine();
                Console.WriteLine("Opening Core Valves.....");
                Console.WriteLine();
                Console.Write("Engaging Fission Prohibitors");
                Program.staggerText("..");
                Console.WriteLine();
                Console.WriteLine("Core Dump Complete");
                Console.WriteLine("REACTOR OFFLINE");
                Console.WriteLine();
                Console.WriteLine("Press [ENTER] to Clear");
                Console.WriteLine();
                input = Console.ReadLine();
                if (input == "")
                {
                    EmergencyPrograms();
                }
                else
                {
                    EmergencyPrograms();
                }
            }
            //haha funny half life reference
            else if (input == "anti resonance")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("ARE YOU SURE? ACTIVIATING ANTI-RESONANCE EMITTERS WILL HAVE UNFORSEEN CONSEQUENCES");
                Console.WriteLine();
                Console.WriteLine("[YES]");
                Console.WriteLine("[NO]");
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.DarkGreen;
                input = Console.ReadLine();
                if (input == "yes")
                {
                    Console.Clear();
                    Program.DataLine();
                    Console.WriteLine();
                    Console.Write("Disengaging Safety Locks");
                    Program.staggerText("...");
                    Console.WriteLine();
                    Console.Write("Diverting Power to Emitters");
                    Program.staggerText(".....");
                    Console.WriteLine();
                    Console.Write("Starting Up Anti-Mass Generators");
                    Program.staggerText("......");
                    Console.WriteLine();
                    Console.Write("Calibrating");
                    Program.staggerText("..");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("FIRING ANTI-RESONANCE EMITTERS IN 5");
                    Thread.Sleep(1000);
                    Console.WriteLine("4");
                    Thread.Sleep(1000);
                    Console.WriteLine("3");
                    Thread.Sleep(1000);
                    Console.WriteLine("2");
                    Thread.Sleep(1000);
                    Console.WriteLine("1");
                    Thread.Sleep(1000);
                    Console.WriteLine("FIRING!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ResetColor();
                    Console.WriteLine("(You hear a huge bang deep from the facility, and feel an unnatural chill run down your spine.)");
                    Thread.Sleep(1000);
                    Console.WriteLine("(Whatever you did caused something big to explode and rip open a hole in the structure of space and time itself.)");
                    Thread.Sleep(1000);
                    Console.WriteLine("(You question why ANSINE had something that dangerous at all, much less how they even made it in the first place.)");
                    Thread.Sleep(1000);
                    Console.WriteLine("(You hear gunfire from right down the hall, and then unearthly screams, and then silence.)");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("(Whatever you did got people killed, and it seems like your luck ran out.");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("The ''DAMN YOU FREEMAN!'' Ending");
                    Console.WriteLine();
                    input = Console.ReadLine();
                }
                else
                {
                    EmergencyPrograms();
                }
            }
            else
            {
                Console.WriteLine("Please Enter a Valid Command.");
                Console.WriteLine("(Press [ENTER] to Continue.)");
                input = Console.ReadLine();
                if (input == "")
                {
                    EmergencyPrograms();
                }
                else
                {
                    EmergencyPrograms();
                }
            }
        }
        //currently unused
        public static void ReactorStatus()
        {

        }
        public static void ReactorLogs()
        {

        }
        //currently partially finished
        public static void ReactorManual()
        {
            Console.Clear();
            Program.DataLine();
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("[so uhhhh this part wasnt completed as it wasn't very necessary and would probably break if you tried to use it.");
            Console.WriteLine("all you need to know is that emergency procedures are how you dont kill everyone.] -gabriel (expert procrastinator)");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("WELCOME TO THE ANSINE.TM ENGINEERS OPERATOR MANUAL");
            Console.WriteLine();
            Console.WriteLine("Please select a passage:");
            Console.WriteLine();
            Console.WriteLine("[1] STARTUP AND SHUTDOWN");
            Console.WriteLine("[2] EMERGENCY PROCEDURES");
            Console.WriteLine("[3] STANDARD OPERATION");
            Console.WriteLine("[4] BACK");
            Console.WriteLine();
            string input = Console.ReadLine();
            if (input == "1")
            {
                //NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE 
                ManualOne();
                input = Console.ReadLine();
                if (input == "1")
                {
                    ManualTwo();
                    input = Console.ReadLine();
                }
                else if (input == "2")
                {
                    ReactorManual();
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Command.");
                    Console.WriteLine("(Press [ENTER] to Continue.)");
                    input = Console.ReadLine();
                    if (input == "")
                    {
                        Parts.ManualOne();
                    }
                    else
                    {
                        Parts.ManualOne();
                    }
                }
            }
            else if (input == "2")
            {
                ManualTwo();
                input = Console.ReadLine();
                if (input == "1")
                {
                    ManualThree();
                    input = Console.ReadLine();
                }
                else if (input == "2")
                {
                    ReactorManual();
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Command.");
                    Console.WriteLine("(Press [ENTER] to Continue.)");
                    input = Console.ReadLine();
                    if (input == "")
                    {
                        Parts.ManualTwo();
                    }
                    else
                    {
                        Parts.ManualTwo();
                    }
                }
            }
            else if (input == "3")
            {
                ManualThree();
                input = Console.ReadLine();
                if (input == "")
                {
                    ReactorManual();
                    input = Console.ReadLine();
                }
                else
                {
                    ReactorManual();
                    input = Console.ReadLine();
                }

            }
            else if (input == "4")
            {
                ConsoleHome();
                Program.Menu();
            }
            else
            {
                Console.WriteLine("Please Enter a Valid Command.");
                Console.WriteLine("(Press [ENTER] to Continue.)");
                input = Console.ReadLine();
                if (input == "")
                {
                    Parts.ReactorManual();
                }
                else
                {
                    Parts.ReactorManual();
                }
            }
        }
        //stuff for the manual
        public static void ManualOne()
        {
            Console.Clear();
            Program.DataLine();
            Console.WriteLine();
            Console.WriteLine("CHAPTER 1: STARTUP AND SHUTDOWN");
            Console.WriteLine();
            Console.WriteLine("ANSINE.TM's CERAPHIME.TM Class Uranium Fission Reactor is outfitted with an Automated Startup and Shutdown (A.S.S.) system.");
            Console.WriteLine("To start up or stop energy production, all an engineer needs to do is to go into the command window and enter the start command, and ");
            Console.WriteLine("the A.S.S system will automatically go through the neccessary procedures necessary.");
            Console.WriteLine();
            Console.WriteLine("Please Select a Command:");
            Console.WriteLine();
            Console.WriteLine("[1] NEXT CHAPTER");
            Console.WriteLine("[2] BACK");
            Console.WriteLine();
        }
        public static void ManualTwo()
        {
            Console.Clear();
            Program.DataLine();
            Console.WriteLine();
            Console.WriteLine("CHAPTER 2: EMERGENCY PROCEDURES");
            Console.WriteLine();
            Console.WriteLine("ANSINE.TM brand reactors are the safest.TM in the industry, but the chance of a meltdown is never zero.");
            Console.WriteLine("In case of a rapid influx in temperature, go to EMERGENCY PROGRAMS on your console and type one of the various commands at your disposal.");
            Console.WriteLine("[ENGAGING] control rods slows down fission reactions, allowing core temperatures to cool.");
            Console.WriteLine("[VENTING] releases all valves and dumps any excess pressure into the atmosphere, bringing a rapid drop in temperature in case of catastrophic core overload.");
            Console.WriteLine("[DUMPING] dumps all nuclear fuel out of the core, bringing fission to a standstill, but requiring a restart, which may increase temperatures again.");
            Console.Write("In case of absolute disaster, activating ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[ANTI-RESONANCE]");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" emitters can bring core temperature to absolute zero in a near instant.");
            Console.WriteLine();
            Console.WriteLine("Keep in mind that the Anti-Resonance emitters are extremely experimental and should only be used as last resort.");
            Console.WriteLine();
            Console.WriteLine("Please Select a Command:");
            Console.WriteLine();
            Console.WriteLine("[1] NEXT CHAPTER");
            Console.WriteLine("[2] BACK");
            Console.WriteLine();
            string input = Console.ReadLine();
            if (input == "1")
            {
                ManualThree();
            }
            else if (input == "2")
            {
                ReactorManual();
            }
            else
            {
                Console.WriteLine("Please Enter a Valid Command.");
                Console.WriteLine("(Press [ENTER] to Continue.)");
                input = Console.ReadLine();
                if (input == "")
                {
                    Parts.ManualTwo();
                }
                else
                {
                    Parts.ManualTwo();
                }
            }
            
        }
        //currently empty
        public static void ManualThree()
        {
            Console.Clear();
            Program.DataLine();
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine("Press [ENTER] to Exit.");
            Console.WriteLine();
        }
    }
}
