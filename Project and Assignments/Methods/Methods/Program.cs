using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            int i; //this sets a standard variable or us to store our method returns
            int j = 0; //this judges how many executions have occured in our while loop.
            op multi = new op(); //this creates a new instance of the class

            Console.WriteLine("Please input a even number to perform a mathematical operation by?"); // asks for user input
            int userInput = Convert.ToInt32(Console.ReadLine()); //saves user input
            Console.WriteLine(multi.Multiply(userInput)); //runs the method (taking in userinput as a parameter) and prints out the resulting integer.
            Console.WriteLine(multi.Divide(userInput)); //runs the method (taking in userinput as a parameter) and prints out the resulting integer.
            Console.WriteLine(multi.Addition(userInput)); //runs the method (taking in userinput as a parameter) and prints out the resulting integer.

            Console.ReadLine();
        }
    }
}
