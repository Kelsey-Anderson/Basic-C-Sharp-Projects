using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Deck    
    {
        public Deck() // constructor that assigns values .. must be at the top 
        {
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j< 4; j++)//nested for loop
                {
                    Card card = new Card();
                    card.Face = (Face)i; //i is an int, we are casting Face (string) to int
                    card.Suit = (Suit)j; //casting Suit to int j
                    Cards.Add(card); // adding this card to our card list
                }
            }

        }
        public List<Card> Cards { get; set; } // property

        public void Shuffle(int times = 1) // Shuffle method (// class method below) - has optional parameter with default value 
        {
           
            for (int i = 0; i < times; i++)
            {
               
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                this.Cards = TempList; // this means it is refering to itself. not required.
            }


        }


    }
}
