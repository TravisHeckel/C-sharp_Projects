using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            mathOP multi = new mathOP(); //calls a instance of the class.

            Console.WriteLine("PLease enter a number."); //this asks for the first number to be typed
            string Answer1 =Console.ReadLine(); //saves first answer
            
            Console.WriteLine("Enter a number only if you want to, otherwise press enter (not necessary)."); //this asks for the second number to be typed.
            string Answer2= Console.ReadLine(); // saves second answer.

            Console.WriteLine("The final answer is " + mathOP.MathOperation(Answer1, Answer2)); //this calls the method and displays the result.

            Console.ReadLine();
        }

    }
}
