using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public class mathOP
    {
        public void MathOperation(int Num1) //void item that returns an integer after taking a value and dividing it.
        {
            int result = Num1 / 2;
            Console.WriteLine(result);
        }

        public int Num1 { get; set; } //this allowed us to access the state of Num1 which is used for the method above.

        public void MathOperation(int Num2, out int result) //this void method output parameter to 'copy' what the result was
        {
            result = Num2 / 2;
        }
        public int Num2 { get; set; } //this allowed us to access the state of Num1 which is used for the method above.
    }

    public static class StaticChallenge
    { 
        public static string StaticFavorite()
        {
            string favoriteNumber = "I love the number 117";
            return favoriteNumber;

        }
    }

}
