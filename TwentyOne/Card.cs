using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Card
    {
        public Card() // constructor method ... is function ... always name of the class
        {
            Suit = "Spades";
                Face = "Two";
        }
        public string Suit { get; set; } //creating a proptery for the class
        public string Face { get; set; }
    }
}
