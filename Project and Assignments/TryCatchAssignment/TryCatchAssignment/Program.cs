using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime currentYear = DateTime.Now; //got the current year

            int year = currentYear.Year; //set the year to its own value.

            try //try this first 
            {

                Console.WriteLine("what is your age?");//ask for input
                int age = Convert.ToInt32(Console.ReadLine()); //record input
                
                if (age == 0 || age < 0) //check for conditions
                {
                    throw new FraudException(Convert.ToString(age)); //throw exception if either condition is true
                }
                year -= age; //year - age gives us the year they where born
                Console.WriteLine("you where born in the year " + year); //prints message

            }
            catch (FraudException ex) //catch for error if the conditions aren't met
            {
                Console.WriteLine(ex.Message); //prints standard message from class
                Console.ReadLine();
                return; 
            }
            catch (Exception) //catch for all other errors
            {
                Console.WriteLine("your input was not a digit!");
                Console.ReadLine();
                return;
            }



            Console.ReadLine();
        }
    }
}
