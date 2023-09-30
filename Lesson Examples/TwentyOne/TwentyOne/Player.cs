using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public Player(string name, int beginningBalance) //takes in the name of a player and the starting $$$
        {
            Hand = new List<Card>(); //creates a "hand" or what cards the play is given
            Balance = beginningBalance; //sets the staring amount of money
            Name = name; //sets the name of the player 
        }

        private List<Card> _hand = new List<Card>(); //creates a private list to store the cards for each hand
        public List<Card> Hand { get { return _hand; } set { _hand = value; } } //this allows the user to access the HAND and either get or set
        public int Balance { get; set; } //allows us to set/get balance
        public string Name { get; set; } //this creates the value for the name
        public bool IsActivelyPlaying { get; set; } //this creates a bool for whether the play is active or not
        public bool Stay { get; set; } //this creates a bool for whether the player wants to keep going or hold what he has

        public bool Bet(int amount) //this bet method takes in the amount and changes the specific players balance
        {
            if (Balance - amount < 0) //checks to see if their are enough funds
            {
                Console.WriteLine("Insufficient funds to place a bet that size."); //sends back rejection message
                return false; //sets Bet to false
            }
            else
            {
                Balance -= amount; //takes the betting amount out of account
                return true; //sets bet to true
            }
        }

        public static Game operator+ (Game game, Player player) //this operator creates an instant of plyer and game when used
        {
            game.Players.Add(player); //adds player to the game class method list called PLAYERS
            return game; //send back the new instance of game.
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player); //removes player from the game class method list called PLAYERS
            return game;//send back the new instance of game.
        }
    }
}
