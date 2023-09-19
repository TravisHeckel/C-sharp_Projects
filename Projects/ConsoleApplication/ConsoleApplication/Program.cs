using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------multiplcation question---------------------------------
            Console.WriteLine("what is your first number? "); //This asks for you to input a number
            string firstA = Console.ReadLine(); //input accepted
            int firstB = Convert.ToInt32(firstA); //converted to an integer
            long firstC = firstB * 50; //multiplied by 50 and saved as a long number in case they chose a large number
            Console.WriteLine(" wee multiplied your number by 50 and that equals " + firstC + '\n'); //print the answer
            //Console.ReadLine(); //Show everything we requested

            //--------------addition question---------------------------------
            Console.WriteLine("what is your second number? "); //This asks for you to input a number
            string secondA = Console.ReadLine(); //input accepted
            int secondB = Convert.ToInt32(secondA); //converted to an integer
            int secondC = secondB + 25; //add 25 to the number inputed and saved as a long number in case they chose a large number
            Console.WriteLine(" we added 25 to your number and that equals " + secondC + '\n'); //print the answer
            //Console.ReadLine(); //Show everything we requested

            //--------------Divided question---------------------------------
            Console.WriteLine("what is your third number? "); //This asks for you to input a number
            string thirdA = Console.ReadLine(); //input accepted
            int thirdB = Convert.ToInt32(thirdA); //converted to an integer
            decimal thirdC = thirdB / 12.5m; //divide by 12.5 to the number inputed and saved as a long number in case they chose a large number
            Console.WriteLine("we divided your number by 12.5 and that equals" + thirdC + '\n'); //print the answer
            //Console.ReadLine(); //Show everything we requested

            //--------------size check question---------------------------------
            Console.WriteLine("what is your fourth number? "); //This asks for you to input a number
            string fourthA = Console.ReadLine(); //input accepted
            int fourthB = Convert.ToInt32(fourthA); //converted to an integer
            bool fourthC; //this is our answer
            if (fourthB <= 50) // checks to see if the number is less than 50
            {
                fourthC = false; // set to false
            }
            else //This defaults that it is bigger than 50
            {
                fourthC = true; //set to true
            }
            Console.WriteLine(" we check to see if your number is greater than 50 and it is " + fourthC + '\n'); //print the answer
            //Console.ReadLine(); //Show everything we requested

            //--------------modulus question---------------------------------
            Console.WriteLine("what is your fifth number? "); //This asks for you to input a number
            string fifthA = Console.ReadLine(); //input accepted
            int fifthB = Convert.ToInt32(fifthA); //converted to an integer
            int fifthC = fifthB % 7; //add 25 to the number inputed and saved as a long number in case they chose a large number
            Console.WriteLine("We divided your number by seven and checked ot see the remainder which equals " + fifthC + '\n'); //print the answer
            //Console.ReadLine(); //Show everything we requested

            Console.ReadLine(); //Show everything we requested
        }
    }
}
