using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway//-----this inherits from game and Iwalkaway
    {
        public TwentyOneDealer Dealer { get; set; }//------------- this creates a new Dealer method in this round using TwentyOneDealer
        public override void Play()//------------- this starts the round off when called by the main.cs
        {
            Dealer = new TwentyOneDealer(); //this creates a new instance of the twentyonedealer
            foreach (Player player in Players) //This sets up each player who will in the game with their own variables
            {
                player.Hand = new List<Card>(); //this gives a new list<hand> for storing cards (EMPTY)
                player.Stay = false; //this marks false as standard for if you want to "STAY OR HIT"
            }
            Dealer.Hand = new List<Card>(); //sets the dealer.hand with a new empty list of card (EMPTY)
            Dealer.Stay = false; //this marks false as standard for if the dealer wants to "STAY OR HIT"
            Dealer.Deck = new Deck(); //this gives a new deck for the dealer to "deal" from
            Dealer.Deck.Shuffle(); //This mixes up the order of the cards.
            //Console.WriteLine("Place your bet!"); //asks for user input

            foreach( Player player in Players) //cycles thru each player in the LIST PLAYERS
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals. ");
                }
                if (bet < 0)
                {
                    throw new FraudException("Security! Kick this person out.");
                }
                bool successfullyBet = player.Bet(bet); //after bet checks to confirm there are enough funds, it will then set successful bet = true
                if(!successfullyBet) //if its false it will return to before the foreach loop and try again
                {
                    return;//this exits the round.
                }
                Bets[player] = bet; //if its true it will add the bet to the dictionary player bets with the key being set as the players name
            }
            for (int i = 0; i < 2; i++) //this cycles twice thru the round giving the user giving the player then dealer a card each time
            {
                Console.WriteLine("Dealing..."); //prints out to user
                foreach(Player player in Players)//cycles thru the palyers
                {
                    Console.Write("{0}: ", player.Name); //prints player name
                    Dealer.Deal(player.Hand); //this gets a card from the dealer
                    if (i == 1) // if i ==1 then the second card is drawn for everyone
                    {
                        bool blackjack = TwentyOneRules.CheckForBlackJack(player.Hand); //this checks to see if the second card given completes a blackjack (=21)
                        if (blackjack) //if it is complete the following commands happen
                        {
                            Console.WriteLine("BlackJack! {0} wins {1}", player.Name, Bets[player]); //prints out who won what
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); //this sets the balance of the winner to equal the money bet + the reward which is 1.5 times the bet amount.
                            Bets.Remove(player); //this removes the player and bet from the dictionary
                            return; //this exits the round.
                        }
                    }
                }
                Console.Write("Dealer: "); //dealer information printed
                Dealer.Deal(Dealer.Hand); //dealer is given a hand
                if (i==1) //this checks if the dealers second hand wins him blackjack
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack) //if won it does a closing statment
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets) //this reviews over each item in the dictionary in case more than 1 person played
                        {
                            Dealer.Balance += entry.Value; //this takes the bets and adds the value to the dealer.

                        }
                        return;//this exits the round. 
                    }
                }
            }
            foreach(Player player in Players) //this cycles thru each player that is playing the game
            {
                while (!player.Stay) //if player = stay is false 
                {
                    Console.WriteLine("Your cards are: ");//ask user a question
                    foreach (Card card in player.Hand) //this prints of each card in the players hand
                    {
                        Console.Write("{0}, ", card.ToString()); //print card as a clear sentence
                    }
                    Console.WriteLine("\n\nHit or stay?");//ask a question
                    string answer = Console.ReadLine().ToLower(); //this accepts user input as an answer
                    if (answer == "stay") //checks to see if they chose stay
                    {
                        player.Stay = true; //set to true
                        break; //break out of while loop 
                    }
                    else if (answer == "hit") //checks to see if they chose hit
                    {
                        Dealer.Deal(player.Hand); //dealer gives out another card to the player 
                    }

                    bool busted = TwentyOneRules.IsBusted(player.Hand); //this checks to see if the player hand is over the limit of 21.

                    if (busted) //if busted is true then print out the below contents
                    {
                        Dealer.Balance += Bets[player]; //add the players bet(s) to the dealers balance
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. your balance is now {2} ", player.Name, Bets[player], player.Balance); //notify the player of the loss
                        Console.WriteLine("Do you want to play again?"); //ask to play again
                        answer = Console.ReadLine().ToLower(); //save the answer and make it all lowercase
                        if (answer == "yes" || answer == "yeah") //check if the answer is yes
                        {
                            player.IsActivelyPlaying = true; //set to true
                            return; //exit out of the foreach loop and proceed on with the program
                        }
                        else
                        {
                            player.IsActivelyPlaying = false; //set as false
                            return; //exit the loop and proceed on with the program
                        }
                    }
                }
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); //this checsk the dealer's hand to see if he is over 21
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); //this checks the criteria to see if dealer is meeting the casino requirements with the cards given

                while (!Dealer.Stay && !Dealer.isBusted) //if both the above options are false, start a loop thru for the dealer until one becomes true
                {
                    Console.WriteLine("Dealer is hitting..."); //tell the dealer he is getting another card
                    Dealer.Deal(Dealer.Hand); //deals a card into the dealers hand
                    Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); //checks his hand again to see if its a bust
                    Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); //checks hand again to see if the dealer will stay
                }
                if (Dealer.Stay) //if dealer stay
                {
                    Console.WriteLine("Dealer is staying"); //let dealer know he is staying
                }
                if (Dealer.isBusted) //if bust is true this will run
                {
                    Console.WriteLine("Dealer Busted!"); //warn that dealer lost
                    foreach (KeyValuePair<Player, int> entry in Bets) //review thru the different pairs in the dictionary
                    {
                        Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value); //print out what each play had won
                        Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); //add the winnings to each players balance in their list
                        Dealer.Balance -= entry.Value; //take the funds out fo the dealer balance
                    }
                    return;//exit the if loop
                }
                
            }
            foreach (Player player in Players) // review thru all players in the player list
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand); //this creates a bool with 3 options, true:false:null. it compares the hand of the user and dealer
                if (playerWon == null) //checks if playerwon ===null
                {
                    Console.WriteLine("Push! No one wins."); //prints a tie
                    player.Balance += Bets[player]; //player gets back his bet
                }
                else if (playerWon == true) //checks if playerwon ===true
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]); //prints out the player won
                    player.Balance += (Bets[player] * 2); //palyer gets his bet back + the reward
                    Dealer.Balance -= Bets[player]; // dealer loses the "reward" amount from his balance

                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]); //print dealer wins
                    Dealer.Balance += Bets[player]; //dealer keeps the bets and adds it to his balance.
                }
                Console.WriteLine("Play again?"); //asks user if they want to play again
                string answer = Console.ReadLine().ToLower(); //records answer
                if (answer == "yes" || answer == "yeah") //checks answer
                {
                    player.IsActivelyPlaying = true; //set true if yes 
                }
                else
                {
                    player.IsActivelyPlaying = false; //set false if no
                }
            }
                //Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); //this checsk the dealer's hand to see if he is over 21
                //Dealer.Stay = TwentyOneRules.ShoulrDealerStay(Dealer.Hand); //this checks the criteria to see if dealer is meeting the casino requirements with the cards given

                //while(!Dealer.Stay && !Dealer.isBusted) //if both the above options are false, start a loop thru for the dealer until one becomes true
                //{
                //    Console.WriteLine("Dealer is hitting..."); //tell the dealer he is getting another card
                //    Dealer.Deal(Dealer.Hand); //deals a card into the dealers hand
                //    Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); //checks his hand again to see if its a bust
                //    Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); //checks hand again to see if the dealer will stay
                //}
                //if (Dealer.Stay) //if dealer stay
                //{
                //    Console.WriteLine("Dealer is staying"); //let dealer know he is staying
                //}
                //if (Dealer.isBusted) //if bust is true this will run
                //{
                //    Console.WriteLine("Dealer Busted!"); //warn that dealer lost
                //    foreach (KeyValuePair<Player, int>  entry in Bets) //review thru the different pairs in the dictionary
                //    {
                //        Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value); //print out what each play had won
                //        Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); //add the winnings to each players balance in their list
                //        Dealer.Balance -= entry.Value; //take the funds out fo the dealer balance
                //    }
                //    return;//exit the if loop
                //}
                //foreach (Player player in Players) // review thru all players in the player list
                //{
                //    bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand); //this creates a bool with 3 options, true:false:null. it compares the hand of the user and dealer
                //    if (playerWon == null) //checks if playerwon ===null
                //    {
                //        Console.WriteLine("Push! No one wins."); //prints a tie
                //        player.Balance += Bets[player]; //player gets back his bet
                //    }
                //    else if (playerWon == true) //checks if playerwon ===true
                //    {
                //        Console.WriteLine("{0} won {1}!", player.Name, Bets[player]); //prints out the player won
                //        player.Balance += (Bets[player] * 2); //palyer gets his bet back + the reward
                //        Dealer.Balance -= Bets[player]; // dealer loses the "reward" amount from his balance

                //    }
                //    else
                //    {
                //        Console.WriteLine("Dealer wins {0}!", Bets[player]); //print dealer wins
                //        Dealer.Balance += Bets[player]; //dealer keeps the bets and adds it to his balance.
                //    }
                //    Console.WriteLine("Play again?"); //asks user if they want to play again
                //    string answer = Console.ReadLine().ToLower(); //records answer
                //    if (answer == "yes" || answer == "yeah") //checks answer
                //    {
                //        player.IsActivelyPlaying = true; //set true if yes 
                //    }
                //    else
                //    {
                //        player.IsActivelyPlaying = false; //set false if no
                //    }
                //}


        }
        public override void ListPlayers()//-------------this list was an override of the games list which sets the list of players
        {
            Console.WriteLine("welcome 21 players!");
            base.ListPlayers();
        }
        public void WalkAway(Player player)//-------------this class was never implemented
        {
            throw new NotImplementedException();
        }
    }
}
