using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class mathOP
    {
        
        public static int MathOperation(int Number1) // this is the first method that multiplies a given number
        {
            Number1 *= 10;
            return Number1;
        }

        public static decimal MathOperation(decimal Number2) // this is the second method that adds a given number
        {
            Number2 += 1.71m;
            return Number2;
        }

        public static int MathOperation(string Number3) // this is the third method that checks to make sure it is a string that can be a number and then divides that number.
        {
            if (Int32.TryParse(Number3, out int result))
            {
                result /= 4;
                return result; 
            }
            else
            {
                return 0;
            }

        }

    }
}
