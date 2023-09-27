using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try //first attempt will be to do this
            {
                Console.WriteLine("Please enter a day of the week"); //ask user for input
                DaysOfTheWeek Day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine()); //assign user input after changing string to enum
                Console.WriteLine(Day); //print example of input
            }
            catch (Exception) //error given if they do not type a correct day of the week
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
    }
   
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
