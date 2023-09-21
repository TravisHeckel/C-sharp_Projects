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
            bool optionPicked = false;
            do
            {
                switch (playersNumber)
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
            Console.WriteLine("GOOD LUCK AND HAVE FUN BATTLING!");
            //----------------Battle time-----------------------------


            //---------------Announce Victory--------------------------


        }
    }
}
