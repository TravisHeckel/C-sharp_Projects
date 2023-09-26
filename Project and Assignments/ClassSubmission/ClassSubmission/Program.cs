using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            mathOP class1 = new mathOP(); //Instance created


            Console.WriteLine("Please input a number"); //asks for input
            class1.Num1 = Convert.ToInt32(Console.ReadLine()); //record answer and change to int

            class1.MathOperation(class1.Num1); ; // This displays the output of the number from a void method

            Console.WriteLine("Please input another number"); //asks for input
            class1.Num2 = Convert.ToInt32(Console.ReadLine()); //record answer and change to int

            class1.MathOperation(class1.Num2, out int result); //run the method that this instance held with the values provided by the user, then change the value of result that EXISTS in our main.
            Console.WriteLine("we took " + class1.Num2 + "/2 equals " + result); //display the answers.

           StaticChallenge.StaticFavorite();

            Console.ReadLine();
        }
    }
}
