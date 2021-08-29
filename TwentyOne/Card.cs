using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public struct Card
    {
        //public Card() // constructor method ... is function ... always name of the class
        //{
        //    Suit = "Spades";
        //        Face = "Two";
        //}
        public Suit Suit { get; set; } //creating a proptery for the class
        public Face Face { get; set; }
    }
    public enum Suit // underlying value is assigned in order [indices]
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
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
