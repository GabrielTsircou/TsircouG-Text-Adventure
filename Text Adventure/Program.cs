using System.ComponentModel.Design;

Console.WriteLine("____  _____  ____");
Console.WriteLine("||  | ||   | ||  | ");
Console.WriteLine("||-<  ||---| ||  |");
Console.WriteLine("||  | ||   | ||  |");
Console.WriteLine("||__/ ||   | ||__/");
Console.WriteLine("");
Console.WriteLine("By GABRIEL TSIRCOU");
Console.WriteLine("");
Console.WriteLine("Options to pick from are in [square brackets], narration are in (parenthases), and speech are in plaintext.");
Console.WriteLine("Make sure you don't misspell anything, as it'll fail and you'll probably have to restart.");
Console.WriteLine("");
Console.WriteLine("[MAIN STORY] or [DEBUG]");
//makes input from the console readable
string input = Console.ReadLine();
//spits out the input
Console.WriteLine("NOW BOOTING: [" + input + "]");

if (input == "DEBUG")
{
    Console.WriteLine("BOOTING UP TEST SIMULATION...");
    Console.WriteLine("please work");
    Console.WriteLine("[1] or [2] or [more]");
    input = Console.ReadLine();
    if (input == "1")
    {
        Console.WriteLine("raaaa");
    }
    else if (input == "2")
    {
        Console.WriteLine("why does nothing ever work");
    }
    else if (input == "more")
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
else if (input == "MAIN STORY")
{
    Console.WriteLine("BEGINNING SIMULATION...");
    Console.WriteLine("...");
    Console.WriteLine("uhh i dont have anything right now oops");
}
else
{
    Console.WriteLine("haha you messed up have fun reloading the program");
}