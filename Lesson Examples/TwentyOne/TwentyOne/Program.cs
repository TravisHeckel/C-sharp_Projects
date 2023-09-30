using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);


            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name."); //ask a question
            string playerName = Console.ReadLine(); //accepts user input1 and saves it
            Console.WriteLine("And how much money did you bring today?");  //ask a question
            int bank = Convert.ToInt32(Console.ReadLine()); //accepts user input2 and saves it
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName); //ask a question
            string answer = Console.ReadLine().ToLower(); //accepts user input3 and saves it
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya") //checks your answer against all the optionss
            {
                Player player = new Player(playerName, bank); //this creates a new player using the PLAYER data type and saves input1 and input2 inside of it
                Game game = new TwentyOneGame(); //This creates a new game using the GAME data type that is specifically set for a new instance of TwentyOneGame.
                game += player; //This adds the player we created earlier to the game variable we created by using the operator +
                player.IsActivelyPlaying = true; //this sets the value for the PLAYER variable to true,confirming that the palyer is playing.
                while (player.IsActivelyPlaying && player.Balance > 0) //this checks that as long as the player has money and is willing to play it will keep cycling thru rounds of the TwentyOneGame
                {
                    
                    game.Play(); //this starts the method play that is set in game class, which redirects to the twentyonegame. (look in there for further details)
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("Feel free to look around the casino. Bye for now");
            Console.Read();
        }

       
    }

}

//Game game = new TwentyOneGame();
//game.Players = new List<Player>();
//Player player = new Player();
//player.Name = "Jesse";
//game = game + player;
//game = game - player;

//Card card1 = new Card();
//Card card2 = card1;
//card1.Face = Face.Eight;
//card2.Face = Face.King;

//Console.WriteLine(card1.Face);



//int count = deck.Cards.Count(x => x.Face == Face.Ace); //1 example
//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); //2example
//List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23, }; //example 3 

//int sum = numberList.Sum(x => x + 5); //example 3
// int sum = numberList.Min(); //example 3 
// int sum = numberList.Where(x => x > 20).Sum(); //example 3 