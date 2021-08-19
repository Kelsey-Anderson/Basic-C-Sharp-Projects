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
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };
            //nested foreach loop:
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }


            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);


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
