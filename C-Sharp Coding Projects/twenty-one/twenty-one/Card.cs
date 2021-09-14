using System;
namespace twenty_one
{
    public class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }

        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
