using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            //Card card = new Card() { Face = "King", Suit = "Spades" }; //object initialization with values

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" }; //initializing(obstantiated) with some values
            //game.ListPlayers();//call the method "superclass method" .. call from a class you inherited from ... "game" is the superclass
            //game.Play(); // calling the play method of the twentyone game object
            //Console.ReadLine();


            // polymorphism .... one object (TwentyOneGame) magically morphs into hirger order object Game
            //List<Game> games = new List<Game>();
            //TwentyOneGame game = new TwentyOneGame(); 
            //games.Add(game);


            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<Player>() { "Jesse", "Billy", "Bob" };//instantiate this list with names
            //game.ListPlayers();
            //Console.ReadLine();

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>(); // instantiate list that's inherited from "GAME" class. must instantiate before we can add to the list
            //Player player = new Player();
            //player.Name = "Jesse";
            //game = game + player; // this is kind of like a method, it returns a game.
            ////shorthand way.... game += player;
            //game = game - player;
            ////shorthand way .... game -= player;


            //Player<Card> player = new Player<Card>(); // creating player object, pass in data type we would want the hand to hold
            //player.Hand = new List<Card>();

            //practicing ENUMs
            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingValue = (int)Suit.Diamonds; // casted suit.diamonds to an integer //could also use Convert.ToInt32(Suit.Diamonds);
            //Console.WriteLine(underlyingValue);

            Deck deck = new Deck();  // creating an object "deck" of deck
            deck.Shuffle(3); // callling the method of shuffle

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);

            Console.ReadLine();
        }



        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
    }
    
}

    

