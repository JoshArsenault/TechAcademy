﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        //dealer properties
        public string Name { get; set; }
        public Deck Deck { get; set; }

        public int Balance { get; set; }

        //deal cards
        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            Deck.Cards.RemoveAt(0);
        }
    }
}
