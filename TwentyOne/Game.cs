using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public abstract class Game // abstract class can never be instantiated, never an object, only inherited from. TEMPLATE.
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set { _players = value; } }//property
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }
        

        public abstract void Play(); //abstract method can only exist inside an abstract class, contains no implementation ... simply states any class inheriting MUST implememnt this method!  
        
        public virtual void ListPlayers() // Virtual keyword inside method class, inherited method, DOES have implementation but has ability to override it.
        {
            foreach(Player player in Players)
            {
                Console.WriteLine(player.Name);

            }
        }

    }
}
