using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class mathOP
    {

        public static int MathOperation(string Number1,  string Number2) 
        {
            int convertedNumber = Convert.ToInt32(Number1);  // this converts it to a int

            if (!string.IsNullOrWhiteSpace(Number2)) //this checks to confirm whether the user gave a correct input
            {
                int convertedNumber2 = Convert.ToInt32(Number2); // this converts it to a int
                int result = convertedNumber + convertedNumber2; //mathematic operation
                return result;
            }
            else //this only returns if the user didn't give an input for Number2
            {
                int result = convertedNumber * 2;
                return result;
            }
            

        }

    }
}
