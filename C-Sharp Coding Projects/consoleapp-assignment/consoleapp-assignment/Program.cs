using System;

namespace consoleapp_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //define actors and actresses
            string[] actorNames = { "Bob Hope", "John Wick", "Johnny Depp", "Spider Man", "Scarlette Johanson" };

            //intro & get funny
            Console.WriteLine("Funny name generator");
            Console.WriteLine("Add some text to be added to an actor name");
            string theFunny = Console.ReadLine();

            //concatenate funny to actorNames
            for (int i = 0; i < actorNames.Length; i++)
            {
                actorNames[i] = actorNames[i] + " " + theFunny;
                Console.WriteLine(actorNames[i]);
            }
            Console.ReadLine();
        }
    }
}
