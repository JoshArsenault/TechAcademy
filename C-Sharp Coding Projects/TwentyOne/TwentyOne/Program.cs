﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Guid identifier = Guid.NewGuid();

            //intro & get player name
            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("How much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
            }

            //ask to join 21 game
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "ya" || answer == "yeah")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out!");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred. Please contact your system administrator.");
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            //exit
            Console.WriteLine("Feel free to look around the casino. Bye for now!");
            Console.Read();
        }
    }
}
