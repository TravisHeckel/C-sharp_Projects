using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings
{
    class Program
    {
        static void Main(string[] args)
        {
                List<int> numbers = new List<int> { 30, 25, 20, 18, 12 }; // set the variable list we will pull from

            for (int i = 0; i < numbers.Count; i++) // for loop to cycle thru the list
            {
                try // this will try running the program regularly
                {
                    Console.WriteLine("I have " + numbers[i] + " cookies, what number would you like to divide them by?");//ask for input
                    int userAnswer = Convert.ToInt32(Console.ReadLine()); //save user input
                    int result = numbers[i] / userAnswer; //perform division operation with input from user and list
                    Console.WriteLine("we will take " + numbers[i] + " cookies and divide it by " + userAnswer + " to equal " + result); //print result
                }
                catch (DivideByZeroException ex) //this will catch any time they try dividing by zero.
                {
                    Console.WriteLine(ex.Message); //this prints error message
                    i -= 1; //this resets counter to current question

                }
                catch (FormatException ex) //this will catch any time they try dividing by a non-number.
                {
                    Console.WriteLine(ex.Message); //this prints error message
                    i -= 1; //this resets count to current question
                }

                Console.WriteLine("\nProgram has completed the operation.\n"); //this confirms that the try/catch was performed


            }
            Console.ReadLine(); //this reads out all the details for the above loop
        }
    }
}
