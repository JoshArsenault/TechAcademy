using System;
using System.Collections.Generic;

namespace consoleapp_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //part 1

            ////define actors and actresses
            //string[] actorNames = { "Bob Hope", "John Wick", "Johnny Depp", "Spider Man", "Scarlette Johanson" };

            ////intro & get funny
            //Console.WriteLine("Funny name generator");
            //Console.WriteLine("Add some text to be added to an actor name");
            //string theFunny = Console.ReadLine();

            ////concatenate funny to actorNames
            //for (int i = 0; i < actorNames.Length; i++)
            //{
            //    actorNames[i] = actorNames[i] + " " + theFunny;
            //    Console.WriteLine(actorNames[i]);
            //}
            //Console.ReadLine();
            //Console.Clear();

            //part 2

            //for (int k = 0; k != 1;)      // add k++ to fix infinite loop
            //{
            //    Console.WriteLine("This is an infinite loop");
            //}

            //part 3

            //for (int j = 0; j < actorNames.Length; j++)
            //{
            //    Console.WriteLine("For each name in an array, this text will show. Except the last one");
            //}

            //for (int j = 0; j <= actorNames.Length; j++)
            //{
            //    Console.WriteLine("For each name in an array, this text will show. Including the last one");
            //}

            //part 4

            //List<string> movieTitles = new List<string>();
            //movieTitles.Add("The Avengers: Endgame");
            //movieTitles.Add("Mrs. Doubtfire");
            //movieTitles.Add("Fast and Furious");
            //movieTitles.Add("Sonic the Hedgehog");
            //movieTitles.Add("A Quiet Place");
            //movieTitles.Add("The Eternals");

            //Console.WriteLine("Search a movie to check our listings");
            //string searchQuery = Console.ReadLine();

            //foreach (string title in movieTitles)
            //{
            //    if (searchQuery.Contains(title))
            //    {
            //        Console.WriteLine("We have this title and it has an index of: " + movieTitles.IndexOf(searchQuery));
            //    }
            //    else
            //    {
            //        Console.WriteLine("We don't have this title at the time, sorry!");
            //    }
            //}
            //Console.ReadLine();

            //part 5

            List<string> tvshows = new List<string>();
            List<string> duplicates = new List<string>();
            tvshows.Add("WandaVision");
            tvshows.Add("Captain America and the Winter Soldier");
            tvshows.Add("Loki");
            tvshows.Add("What If");
            tvshows.Add("WandaVision");

            foreach (string tvshow in tvshows)
            {
                if (duplicates.Contains(tvshow))
                {
                    Console.Write(tvshow);
                    Console.Write(" and it is a duplicate");
                }
                else
                {
                    duplicates.Add(tvshow);
                    Console.WriteLine(tvshow);
                }
            }
            Console.ReadLine();
        }
    }
}
