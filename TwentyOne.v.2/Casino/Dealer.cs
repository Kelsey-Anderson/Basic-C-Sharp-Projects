using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
   public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());//grab first card and add to hand
            string card = string.Format(Deck.Cards.First().ToString() + "\n"); //logging each card
            Console.WriteLine(card);//print which card was dealt to the console


            using (StreamWriter file = new StreamWriter(@"C:\Users\15419\Documents\GitHub\Basic-C-Sharp-Projects\TwentyOne.v.2\log.txt", true))
            {
                file.WriteLine(DateTime.Now); //property that gives the exact datetime object of this moment
                file.WriteLine(card);
            }

            Deck.Cards.RemoveAt(0);//index of what we want to remove ...the first one is 0

        }
    }
}
