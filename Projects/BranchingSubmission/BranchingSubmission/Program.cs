using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmission
{
    class Program
    {
        static void Main(string[] args)
        {   //-----------------------------INTRO-------------------------------------------------
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            //---------------------------THIS DETERMINES WEIGHT----------------------------------
            Console.WriteLine("What is the weight of the package you wish to ship?"); //This requests user input
            int weight = Convert.ToInt32(Console.ReadLine()); //this saves the input and converts it to the proper form

            //string check = (weight > 50.00) ? "Package too heavy to be shipped via Package Express. Have a good day" : "\n"; //warning if the package weight is to heavy
            //Console.WriteLine(check);//this prints off the ternary statment above.
            
            if (weight > 50.00)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
                Console.WriteLine("Tap enter to exit");
                Console.ReadLine();
                return;

            } 

            //-------------------------THIS DETERMINES PROPROTIONS------------------------------
            Console.WriteLine("What is the width of the package you wish to ship?");//This requests user input
            int width = Convert.ToInt32(Console.ReadLine());//this saves the input and converts it to the proper form

            Console.WriteLine("What is the height of the package you wish to ship?");//This requests user input
            int height = Convert.ToInt32(Console.ReadLine());//this saves the input and converts it to the proper form

            Console.WriteLine("What is the length of the package you wish to ship?");//This requests user input
            int length = Convert.ToInt32(Console.ReadLine());//this saves the input and converts it to the proper form


            int dimensions = width + height + length; //basic math to calculate total volume of each package.
            //string check2 = (dimensions > 50) ? "Package too large to be shipped via Package Express. Have a good day" : ""; //warning if the package size is to big.
            //Console.WriteLine(check2); //this prints off the ternary statment above.

            if (dimensions > 50)
            {
                Console.WriteLine("Package too large to be shipped via Package Express. Have a good day");
                Console.WriteLine("Tap enter to exit");
                Console.ReadLine();
                return;

            }
            //--------------------CALCULATE COSTS----------------------------------------------

            decimal cost = (dimensions * weight) / 100.00m; //This calculates the cost of the product.
            Console.WriteLine("Your estimate total for shipping this package is: $" + cost.ToString("0.00")); //this displays the final estimate.


            Console.ReadLine();
        }   
    }
}
