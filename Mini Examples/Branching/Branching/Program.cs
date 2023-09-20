using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {

            int roomTemperature = 70;
            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi " + name + " what is the temperature where you live?");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (currentTemperature < roomTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("uhhhh.... something went wrong.");
            //}

            //-------------YOU CAN DO THIS BELOW TO MATCH WHAT WAS DONE ABOVE---------------------
            
            string comparisonResults = (currentTemperature == roomTemperature) ? "It is room temp." : (currentTemperature > roomTemperature) ? "It is warmer than room temperature." : (currentTemperature < roomTemperature) ? "It is colder than room temperature.": "uhhhh.... something went wrong." ;
            
            Console.WriteLine(comparisonResults);


            Console.ReadLine();
        }
    }
}
