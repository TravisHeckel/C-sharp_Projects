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

            Console.WriteLine("Please choose a starter pokemon! (type the number of your choice)");//question posed to the user.
            Console.WriteLine("1. Bulbasaur \n2. Charmander \n3. Squirtle \n");//options shared
            int playerChoice = Convert.ToInt32(Console.ReadLine());//accept user input

            bool choice = false;//default value given
            string playerOne;//default value given

            while (choice != true) //A while loop that will only stop once a player picks the options.
            {
                if (playerChoice == 1) //This gives standard options
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
                    Console.WriteLine("OOPS! looks like you didn't pick one. Please choose again"); //This asks them to pick again if a invalid choice is given
                    Console.WriteLine("1. Bulbasaur \n2. Charmander \n3. Squirtle \n");
                    playerChoice = Convert.ToInt32(Console.ReadLine());//accept user input
                }
            }

            //----------------Choose Opponent--------------------------
            Console.WriteLine("Now choose a number between 1-3 to be matched up to your opponent!"); //This tells you tp ick a number to find your opponent
            int playersNumber = Convert.ToInt32(Console.ReadLine());//accept user input
            bool optionPicked = false;//default value given
            do //this do will replay thru the switch if invalid answer is given
            {
                switch (playersNumber) //this details each of the opponent options
                {
                    case 1:
                        Console.WriteLine("You will be facing a Bulbasaur!");
                        optionPicked = true;
                        break;
                    case 2:
                        Console.WriteLine("You will be facing a Charmander!");
                        optionPicked = true;
                        break;
                    case 3:
                        Console.WriteLine("You will be facing a Squirtle!");
                        optionPicked = true;
                        break;

                    default:
                        Console.WriteLine("Sorry what you typed is not an option.");
                        Console.WriteLine("choose another number?");
                        playersNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (optionPicked == false);

            Console.ReadLine();
            Console.WriteLine("GOOD LUCK AND HAVE FUN BATTLING!"); // wishes player good luck
            //----------------Battle time-----------------------------


            //---------------Announce Victory--------------------------


        }
    }
}
