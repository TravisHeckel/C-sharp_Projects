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

            mathOP.MathOperation(10, 6); // set the numbers directly in activating the method

            multi.Number1 = 45; // set its own variables outside of method, but in that instance
            multi.Number2 = 30; // set its own variables outside of method, but in that instance

            mathOP.MathOperation(multi.Number1, multi.Number2); // activated the method using both the variables we created in this instance.
           
            Console.ReadLine();
        }

    }
}
