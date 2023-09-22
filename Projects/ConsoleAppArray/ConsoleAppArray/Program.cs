using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main()
        {

            //-----------------This sets the title of the menu--------------------------------
            Console.WriteLine("Sushi Restaurant Menu");

            //-----------------Picking the menu option------------------------------------------
            Console.WriteLine("Please type the number of the option you would like from below");
            List<string> menuList = new List<string>(); //This shares a menu with the customer
            menuList.Add(" Sushi Rolls"); //adding to the list
            menuList.Add(" Soups"); //adding to the list
            menuList.Add(" Chicken"); //adding to the list

            for (int i =0; i < menuList.Count; i++) //This is used to display each item in the list
            {
                Console.WriteLine( (i+1) + menuList[i]);
            }

            int customerChoice = Convert.ToInt32(Console.ReadLine()); //This converts the user input to an integer

            customerChoice --; //takes away one on the users choice count

            //-----------------Arrays used in the formulas below---------------------------

            string[] sushiRollsArray = { " California roll", " Dragon roll", " Vegas roll" }; //this is an array of sushi rolls

            string[] soupsArray = { " Fu yun soup", " Spicy tofu soup", " Miso soup", }; //this is an array of sushi rolls

            string[] chickenArray = { " Barbque chicken ", " Teriyaki chicken", " Orange chicken" }; //this is an array of sushi rolls

            string[] newArray = new string[3];

            bool correctChoice = false;

            while (correctChoice != true) //This checks to see if the correct input was provided.
            {
                if (customerChoice == 0) // if correct input is given a sushi roll array will be displayed next
                {
                    sushiRollsArray.CopyTo(newArray, 0); 
                    correctChoice = true;
                }
                else if (customerChoice == 1) // if correct input is given a soup array will be displayed next
                {
                    soupsArray.CopyTo(newArray, 0); 
                    correctChoice = true;
                }
                else if (customerChoice == 2) //if correct input is given a chicken array will be shared next
                {
                    chickenArray.CopyTo(newArray, 0);
                    correctChoice = true;
                }
                else//if incorrect input is provided it will ask again.
                {
                    Console.WriteLine("Apologies, but the input given does not match any of the options presented.");
                    Console.WriteLine("Please type the number of the option you would like.");
                    customerChoice = Convert.ToInt32(Console.ReadLine()); //This converts the user input to an integer
                    customerChoice--; //takes away one on the users choice
                }
            }


            //---------------------Picking the specific item choice---------------------------------------------

            int customer2Choice;
            bool correct2Choice = false;

            Console.WriteLine("Please type the number of the option you would like from below");
            for (int i = 0; i < newArray.Length; i++) //This is used to display each item in the list
            {
                Console.WriteLine((i + 1) + newArray[i]);
            }
            customer2Choice = Convert.ToInt32(Console.ReadLine()); //This converts the user input to an integer
            customer2Choice--; //takes away one on the users choice

            while (correct2Choice != true)
            {
                if (customer2Choice == 0 || customer2Choice == 1 || customer2Choice == 2)
                {
                    correct2Choice = true;
                }
                else
                { 
                    Console.WriteLine("Apologies, but the input given does not match any of the options presented.");
                    Console.WriteLine("Please type the number of the option you would like.");
                    customer2Choice = Convert.ToInt32(Console.ReadLine()); //This converts the user input to an integer
                    customer2Choice--; //takes away one on the users choice count
                }
            }

            //-----------------this issues a request for how many they would like ---------------------
            
            int[] qtyArray = { 1, 2,3}; //this is an array of quantities that are chosen
            int customer3Choice;
            bool correct3Choice = false;

            Console.WriteLine("Please type the number of the amount you would like from below");
            for (int i = 0; i < qtyArray.Length; i++) //This is used to display each item in the list
            {
                Console.WriteLine(qtyArray[i] + " servings");
            }
            customer3Choice = Convert.ToInt32(Console.ReadLine()); //This converts the user input to an integer
            customer3Choice--; //takes away one on the users choice


            //--------------this displays their final choices------------------------------------



            while (correct3Choice != true)
            {
                if (customer3Choice == 0 || customer3Choice == 1 || customer3Choice == 2)
                {
                    correct3Choice = true;
                }
                else
                {
                    Console.WriteLine("Apologies, but the input given does not match any of the options presented.");
                    Console.WriteLine("Please type the number of the option you would like.");
                    customer2Choice = Convert.ToInt32(Console.ReadLine()); //This converts the user input to an integer
                    customer2Choice--; //takes away one on the users choice count
                }
            }

            Console.WriteLine("You wanted" + menuList[customerChoice] + "!" + "\n You chose " + qtyArray[customer3Choice] + " serving(s) of" + newArray[customer2Choice] + "."); //this prints the choice the user made from the list

            Console.ReadLine(); //This makes sure everything is displayed to the user and not jsut processed.
        }
    }
}
