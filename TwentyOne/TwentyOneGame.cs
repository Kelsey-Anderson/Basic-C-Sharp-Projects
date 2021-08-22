using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class TwentyOneGame : Game  // this inherits from the class Game
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
    }
}
