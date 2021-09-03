using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card
    {
        public Suit Suit { get; set; } //creating a proptery for the class
        public Face Face { get; set; }

        public override string ToString()
            {
                return string.Format("{0} of {1}", Face, Suit);
            }
        }
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

