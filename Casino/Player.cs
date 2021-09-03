using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public class Player //<T> the <T> makes the class generic, 
    {
        //constructor goes at top of the class
        public Player(string name, int beginningBalance) //constructor takes two arguments
        {
            Hand = new List<Card>(); // have to initialize list so we can add things to it
            Balance = beginningBalance;
            Name = Name;

        }

        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } } //instead of <Card> change to <T> for generics
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool stay { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        //adding an overloaded operator method:
        public static Game operator +(Game game, Player player) //taking two operands(game and player)
        {
            game.Players.Add(player);     //game passed in as parameter
            return game; //returning a game
        }
        // subtract overload operator:
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;

        }
    }
}
