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

            //Card card1 = new Card();
            //Card card2 = card1; // reference type. Assigning value of card1 to card2, did NOT create a new card. Rather, we gave card2 the address to memory location of card1 to refer to. (think of google doc, one single central doc)
            //card1.Face = Face.Eight;//if changing the CARD CLASS to be STRUCT instead, this will show Eight (card1 and card 2 are own separate instances)
            //card2.Face = Face.King;//Leaving the CARD CLASS as it is will show King

            //Console.WriteLine(card1.Face);

            

            //*List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); 
            //Take list of cards and find out where the Face = king and map it to a NEW list.
            //Where() is a lambda function, filter lists
            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face); // prints all items in the new list
            //}


            //another example
            //List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
            //int sum = numberList.Sum(); // can add add'l math inside Sum(x => x + 5); adds 5 to each item in list
            //Console.WriteLine(sum);



            // int count = deck.Cards.Count(x => x.Face == Face.Ace); 
            // Cards is a list, Count() is a lambda function. Counting the elements in the list (x) where = Ace

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

    

