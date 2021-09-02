using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway  // this inherits from the class Game, and the 2nd is interface
    {
        public TwentyOneDealer Dealer { get; set; }

        public override void Play() // inherited PLAY from Game, but must override the abstract method type
        {
            Dealer = new TwentyOneDealer();
            foreach(Player player in Players)
            {
                player.Hand = new List<Card>(); //each round, reset the player's hand
                player.stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck(); // new deck each time
            Dealer.Deck.Shuffle();
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet); //passing in the amount they entered into the bet method
                if (!successfullyBet)
                {
                    return; //return in void method == end this method.
                }
                Bets[player] = bet; //add entry of player name and the bet amount to dictionary object
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.WriteLine("{0}: ", player.Name);
                    Dealer.Deal(player.Hand); //passing into the player's hand
                    if (i == 1) // after the second card is dealt...
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand); // passing in players hand tocheck for blackjack
                        if (blackJack)
                        {
                            Console.WriteLine("B L A C K J A C K!! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return; // round is over
                        }

                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BLACKJACK! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value; // iterates through and gives dealer all bets
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if(answer == "stay")
                    {
                        player.stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} BUSTED!! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting ...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);

            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");

            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer is BUSTED!");
                foreach (KeyValuePair<Player, int>entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); //lambda expression
                    Dealer.Balance -= entry.Value;

                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);  //null-able boolean 
                if (playerWon == null)
                {
                    Console.WriteLine("Push! no one wins..");
                    player.Balance += Bets[player];

                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }

            }

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
