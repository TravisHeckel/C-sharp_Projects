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
            while (j < 3) //this runs through the code below asking the user or a number and performing a mathematical operation.
            {
                Console.WriteLine("Please input a even number to perform a mathematical operation by?");
                multi.Number1 = Convert.ToInt32(Console.ReadLine());
                if (j == 0) //this checks which of the operational methods to use.
                {
                    i = multi.Multiply(); //this uses the method in the class.
                }
                else if (j == 1)
                {
                    i = multi.Divide(); //this uses the method in the class.
                }
                else
                {
                    i = multi.Addition(); //this uses the method in the class.

                }
                Console.WriteLine(multi.Number1 + multi.numer + multi.Number2 + " is " + i); // this prints the result
                j++;
            }
            Console.WriteLine("Thank you for testing this system");
            Console.ReadLine();
        }
    }
}
