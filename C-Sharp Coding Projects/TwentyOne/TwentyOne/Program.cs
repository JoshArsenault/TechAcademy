using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            card.Suit = Suit.Clubs;
            int underlyingValue = Convert.ToInt32(Suit.Diamonds);
            Console.WriteLine(underlyingValue);
            

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
