using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //template card class
    public class Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }

    //all possible suits
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    //all possible faces
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
