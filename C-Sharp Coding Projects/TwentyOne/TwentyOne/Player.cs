using System;
using System.Collections.Generic;

namespace TwentyOne
{
    public class Player
    {
        // add player to game
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        // remove player from game
        public static Game operator -(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        //player properties
        public List<Card> Hand { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public bool isActivelyPlaying { get; set; }
    }
}
