using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Console.WriteLine("What is your name?");
            //   string yourName = Console.ReadLine();
            //   Console.WriteLine("Your name is: " + yourName);
            //   Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            //int CurrentAge = 30;
            //string yearsOld = CurrentAge.ToString();
            //   Console.WriteLine(yearsOld);
            //   Console.ReadLine();

            //bool isRaining = true;
            //string rainStatus = Convert.ToString(isRaining);
            //   Console.WriteLine(rainStatus);
            //   Console.ReadLine();

            bool isStudying = false; //only true or false
            byte hoursWorked = 42; //This is positive bytes
            sbyte currentTemperature = -23; // this includes positive and negative bytes
            char questionMark = '\u2103'; //This is unicode characters
            decimal moneyInBank = 100.50m; //This is mainly used for money
            double heightInCentimeters = 211.302020292; //This is used for large numbers
            float secondsLeft = 2.62f; //is a smaller decimal number
            short temperatureOnMars = -341;
            string myName = "Jesse";

            Console.WriteLine(questionMark);

            int num1 = 3;
            int num2 = 5;

            string result = num1 >= num2 ? "wow your right.": "No your wrong.";
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
