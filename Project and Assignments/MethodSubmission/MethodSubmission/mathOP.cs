using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class mathOP
    {

        
        public void MathOperation(int Number1,  int Number2 = 2) //This method allows for two parameters
        {
            int calculate = Number1 - Number2; //this runs a calcuation on parameter one

            Console.WriteLine("the answer is " + calculate); //this one printed the second variable to the screen

            return;

        }
        //public int Number1 { get; set; } //set the variables that can be accessed by the instance
        //public int optionalNumber { get; set; }  //set the variables that can be accessed by the instance

    }
}
