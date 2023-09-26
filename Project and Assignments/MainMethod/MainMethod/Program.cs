using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            mathOP mutli = new mathOP(); //calls a instance of the class.
            
            int Number1 = 6; //sets our  variable
            Console.WriteLine(Number1 + " times 10 equals " + mathOP.MathOperation(Number1) + '\n');

            decimal Number2 = 6.99m; //sets our  variable
            Console.WriteLine("$"+ Number2 + " + $1.71 for gas money means you owe me $" + mathOP.MathOperation(Number2) + '\n');

            //string Number3 = "c"; //sets our  variable
            int result = mathOP.MathOperation("8"); //sets our answer after running the method

            Console.WriteLine("the result was " + result);
            //if (result > 0) //checks to see if 0 is passed as an error
            //{
            //    Console.WriteLine(Number3 + " divided by 4 equals " + mathOP.MathOperation(Number3) + '\n');
            //}
            //else
            //{
            //    Console.WriteLine("Sorry the input you gave does not provide an appropriate number." + '\n');
            //}

            Console.ReadLine();
        }
    
    }
}
