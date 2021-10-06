using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game
    {
        //TwentyOneGame properties
        public TwentyOneDealer Dealer { get; set; }

        //start game
        public override void Play()
        {
            Dealer = new TwentyOneDealer();

            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet == false)
                {
                    return;
                }
                Bets[player] = bet;
            }


        }

        //list players in game
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }

        //walk away from game
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
