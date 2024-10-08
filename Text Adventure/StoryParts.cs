using Text_Adventure;

namespace StoryParts
{
    public class parts
    {
        public static void Please()
        {
            Program.staggerText("if you can read this somethings working!");
        }
        public static void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_____ __ __ ______ _____  __     _____ _____ _____");
            Thread.Sleep(200);
            Console.WriteLine("||  | ||  | ||     ||   | ||     ||  | ||  | ||  |");
            Thread.Sleep(200);
            Console.WriteLine("||  | ||  | ||__   ||--/  ||     ||  | ||--| ||  |");
            Thread.Sleep(200);
            Console.WriteLine("||  | || /  ||     ||   | ||     ||  | ||  | ||  |");
            Thread.Sleep(200);
            Console.WriteLine("||__| ||/   ||____ ||   | ||____ ||__| ||  | ||__/");
            Thread.Sleep(100);
            Console.ResetColor();
            Thread.Sleep(100);
            Console.WriteLine("");
            Console.WriteLine("By GABRIEL TSIRCOU");
            Console.WriteLine("");
            Thread.Sleep(300);
            Console.WriteLine("Narration are in (Parentheses), speech are in plaintext and are in different colors for different people...");
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
            Console.WriteLine("");
            Console.WriteLine("Please Enter Credentials:");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("(You don't remember your passkey. You try not to stress about it as it was given to you an hour ago, but you still feel bad)");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
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
            Console.WriteLine("(You call someone over to help you sign in to the console.)");
        }
        public static void InGuess()
        {
            Console.WriteLine("(You give up trying to remember your password and guess something random.");

        }
        public static void BootUp()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Beep();
            Console.WriteLine("     ________   ___    __   _______   _____   ___    __   ________");
            Thread.Sleep(100);
            Console.WriteLine("    //      /   //|    /   //          //     //|    /   //");
            Thread.Sleep(100);
            Console.WriteLine("   //======/   // |   /   //_____     //     // |   /   //__");
            Thread.Sleep(100);
            Console.WriteLine("  //      /   //  |  /          /    //     //  |  /   //   ");
            Thread.Sleep(100);
            Console.WriteLine(" //      /   //   | /          /    //     //   | /   //");
            Thread.Sleep(100);
            Console.WriteLine("//      /  _//_  _|/_   ______/  __//__  _//_  _|/_  //______");
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
        }
    }
}