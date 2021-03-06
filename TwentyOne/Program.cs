using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino.TwentyOne;
using Casino;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

          
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);

            //string answer = Console.ReadLine().ToLower(); //makes their answer lowercase
            Console.WriteLine(Console.ReadLine());

            string answer = "yes";
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya") //check for variety of answers 
            {
                Player player = new Player(playerName, bank); //create a new player object .. initialize him
                Game game = new TwentyOneGame(); //polymorphism
                game += player; //adding player to the game
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player; //when while loop ends, player exists game
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();

        }
    }
    
}

    

