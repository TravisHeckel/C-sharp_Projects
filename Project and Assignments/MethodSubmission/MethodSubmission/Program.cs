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

            Console.WriteLine("Please input a number you wish to use."); //asks for user input
            int Number1 = Convert.ToInt32(Console.ReadLine()); //records users answer
            
            Console.WriteLine("if you wish you can either input another number or press enter"); //asks for user input
            string optionalNumber = Console.ReadLine(); //records users answer

            if (!string.IsNullOrEmpty(optionalNumber)) //checks answer to see if applicable to what was asked.
            {
                int Number2 = Convert.ToInt32(optionalNumber); //converts to int
                multi.MathOperation(Number1, Number2); //sends off the two parameters
            }
            else
            {
                multi.MathOperation(Number1); //sends of one parameter and lets the optional one default
            }

           
            Console.ReadLine();
        }

    }
}
