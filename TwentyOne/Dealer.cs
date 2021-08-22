using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwentyOne
{
   public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());//grab first card and add to hand
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");//print which card was dealt to the console
            Deck.Cards.RemoveAt(0);//index of what we want to remove ...the first one is 0

        }
    }
}
