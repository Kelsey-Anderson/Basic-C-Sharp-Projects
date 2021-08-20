using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class TwentyOneGame : Game  // this inherits from the class Game
    {
        public void Play() // specific to 21game now, rather than game
        {
            throw new NotImplementedException(); // this makes an error get thrown - catch to avoid running method before we can define it.
        }
    }
}
