using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class mathOP
    {
        public static int MathOperation() //Changed this to a static and had it return a value directly from the class.
        {
            int result = 8 / 2;
            return result;
        }

        public void MathOperation(int Num1, out int result) //this void method output parameter to 'copy' what the result was
        {
            result = Num1 / 2;
        }
        public int Num1 { get; set; } //this allowed us to access the state of Num1 which is used for the method above.
    }
}
