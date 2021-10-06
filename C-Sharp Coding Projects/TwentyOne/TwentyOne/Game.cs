using System;
using System.Collections.Generic;

namespace TwentyOne
{
    public abstract class Game
    {
        // start game method
        public abstract void Play();

        // display all players in game
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }

        // game properties
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }
    }
}
