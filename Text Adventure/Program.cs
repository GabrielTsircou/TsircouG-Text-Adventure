using System.ComponentModel.Design;

namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wake up in the morning fellin like p diddy");
            Console.WriteLine("[please leave me alone] or [YES ZADDY]");

            string input = Console.ReadLine();
            Console.WriteLine(input);
            if (input == "please leave me alone")
            {
                Console.WriteLine("dont care TIME FOR THE DIDDY GAMES!!!!!!!!!!!!!!!");
                Console.WriteLine("(you see some stuff to defend yourself nearby. what do you grab?)");
                Console.WriteLine("[bottle of baby oil on a nearby table] or [diddy's pistol strapped to his side]");
                Console.ReadLine();
                if (input == "bottle of baby oil on a nearby table")
                {
                    Console.WriteLine("(KABLAM!)");
                    Console.WriteLine("(holy sht you just killed diddy)");
                    Console.WriteLine("congrats you won");
                }
                else if (input == "diddy's pistol strapped to his side")
                {
                    Console.WriteLine("(you grab his pistol and wrestle if off of his oily hip. who do you point it at?)");
                    Console.WriteLine("[diddy] or [yourself]");
                    Console.ReadLine();
                    if (input == "diddy")
                    {
                        Console.WriteLine("(you swing the gun on him)");
                        Console.WriteLine("dawg what-");
                        Console.WriteLine("(POW!)");
                        Console.WriteLine("you did it yay");
                    }
                    else if (input == "yourself")
                    {
                        Console.WriteLine("(you swing the pistol onto yourself, andddddhglkfb jsbni ----.fsfs-f-.s.-f..");
                        Console.WriteLine("[ERROR]");
                        Console.WriteLine("[ERROR]");
                        Console.WriteLine("[ERROR]");
                        Console.WriteLine("[INVALID TIMELINE ENTERED]");
                        Console.WriteLine("{REWRITING...]");
                        Console.WriteLine("[REWRITE COMPLETE. RESUMING SIMULATION]");
                        Console.WriteLine("(you swing the gun on him)");
                        Console.WriteLine("dawg what-");
                        Console.WriteLine("(POW!)");
                        Console.WriteLine("you did it yay");
                    }
                }
                else
                {
                    Console.WriteLine("nuh uh");
                }
            }
            else if (input == "YES ZADDY")
            {
                Console.WriteLine("consent ew");
            }
            else
            {
                Console.WriteLine("WRONG ANSWER *POW!* *POW!* *POW!* *POW!* *POW!* *POW!* *POW!* *POW!* *reload* *POW!* *POW!* *POW!* *POW!* *POW!* *P");
            }
        }
    }
}
// gettin FREAKY in command line........ 👅👅👅
//i NEED to kill myself
