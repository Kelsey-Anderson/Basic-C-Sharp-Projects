using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        //adding an overloaded operator method:
        public static Game operator+ (Game game, Player player) //taking two operands(game and player)
        {
            game.Players.Add(player);     //game passed in as parameter
            return game; //returning a game
        }
        // subtract overload operator:
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;

        }
    }
}
