using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public abstract class Game // abstract class can never be instantiated, never an object, only inherited from. TEMPLATE.
    {
        public List<Player> Players { get; set; } //property
        public string Name { get; set; }
        public string Dealer { get; set; }

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
