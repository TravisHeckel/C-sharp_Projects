using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class
{
    class mathOP
    {
        public static void MathOperation(int Number1, int Number2) //This method allows for two parameters
        {
            int calculate = Number1 - 5; //this runs a calcuation on parameter one

            Console.WriteLine("you chose the number " + Number2); //this one printed the second variable to the screen

            return;

        }
        public int Number1 { get; set; } //set the variables that can be accessed by the instance
        public int Number2 { get; set; }  //set the variables that can be accessed by the instance
    }
}
