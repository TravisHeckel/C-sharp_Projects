using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";


            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName); //ask a question
            string playerName = Console.ReadLine(); //accepts user input1 and saves it
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach(var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only.");
            }

            //Console.WriteLine("And how much money did you bring today?");  //ask a question
            //int bank = Convert.ToInt32(Console.ReadLine()); //accepts user input2 and saves it


            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName); //ask a question
            string answer = Console.ReadLine().ToLower(); //accepts user input3 and saves it
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya") //checks your answer against all the optionss
            {
                Player player = new Player(playerName, bank); //this creates a new player using the PLAYER data type and saves input1 and input2 inside of it
                player.Id = Guid.NewGuid(); //this creates a new instance of GUID
                using (StreamWriter file = new StreamWriter(@"C:\Users\theck\Documents\Repositories\GitHub\Basic_C-Sharp_Projects\Lesson Examples\Logs\log.txt", true)) //this posts where we are writing the log too
                {
                    file.WriteLine(player.Id); //this writes the player id to the log.

                }
                Game game = new TwentyOneGame(); //This creates a new game using the GAME data type that is specifically set for a new instance of TwentyOneGame.
                game += player; //This adds the player we created earlier to the game variable we created by using the operator +
                player.IsActivelyPlaying = true; //this sets the value for the PLAYER variable to true,confirming that the palyer is playing.
                while (player.IsActivelyPlaying && player.Balance > 0) //this checks that as long as the player has money and is willing to play it will keep cycling thru rounds of the TwentyOneGame
                {
                    try
                    {
                        game.Play(); //this starts the method play that is set in game class, which redirects to the twentyonegame. (look in there for further details)
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithExceptions(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured. Please contact your Systems Administration.");
                        UpdateDbWithExceptions(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("Feel free to look around the casino. Bye for now");
            Console.Read();
        }

       private static void UpdateDbWithExceptions(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) 
                                    VALUES(@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.VarChar);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp from Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
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