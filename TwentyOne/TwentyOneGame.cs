using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway  // this inherits from the class Game, and the 2nd is interface
    {
        public override void Play() // inherited PLAY from Game, but must override the abstract method type
        {
            throw new NotImplementedException(); // this makes an error get thrown - catch to avoid running method before we can define it.
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers(); // this base defaults, its equivalent of the abstract class Game defaults
        }
        public void WalkAway(Player player) //this must be a void - interface class
        {
            throw new NotImplementedException(); // not implemented yet
        }
    }
}
