using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------Title of Game----------------------------
            
            Console.WriteLine("Welcome to the pokemon practice battle arena!");

            //----------------starter Pokemon--------------------------

            Console.WriteLine("Please choose a starter pokemon! (type the number of your choice)");
            Console.WriteLine("1. Bulbasaur \n2. Charmander \n3. Squirtle \n");
            int playerChoice = Convert.ToInt32(Console.ReadLine());

            bool choice = false;
            string playerOne;

            while (choice != true)
            {
                if (playerChoice == 1)
                {
                    playerOne = "Bulbasaur";
                    Console.WriteLine("You chose " + playerOne + " good luck!");
                    choice = true;
                    
                }
                else if (playerChoice == 2)
                {
                    playerOne = "Charmander";
                    Console.WriteLine("You chose " + playerOne + " good luck!");
                    choice = true;
                    
                }
                else if (playerChoice == 3)
                {
                    playerOne = "Squirtle";
                    Console.WriteLine("You chose " + playerOne + " good luck!");
                    choice = true;
                }
                else
                {
                    Console.WriteLine("OOPS! looks like you didn't pick one. Please choose again");
                    Console.WriteLine("1. Bulbasaur \n2. Charmander \n3. Squirtle \n");
                    playerChoice = Convert.ToInt32(Console.ReadLine());
                }
            }

            //----------------Choose Opponent--------------------------
            Console.WriteLine("Now choose a number between 1-3 to be matched up to your opponent!");
            int playersNumber = Convert.ToInt32(Console.ReadLine());

            do
            {
                switch (playersNumber)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        playersNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        playersNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        playersNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);




            //----------------Battle time-----------------------------


            //---------------Announce Victory--------------------------






            Console.ReadLine();
        }
    }
}
