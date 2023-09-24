using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");//This asks for the age
            string XP = Console.ReadLine();//this stores the response
            int AGE = Convert.ToInt32(XP);//This converts the string to int

            Console.WriteLine("Have you ever had a DUI? (please type true or false)");//This asks for the age
            string count = Console.ReadLine();//this stores the response
            count.ToLower();
            bool end = false;
            while (end != true) //This makes sure they type a response that is true or false
            {
                if (count == "true" || count == "false")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please answer true or false");
                    count = Console.ReadLine();
                    count.ToLower();
                }
            }
            bool DUI = Convert.ToBoolean(count);

            Console.WriteLine("How many speeding tickets do you have?");//This asks for the age
            string number = Console.ReadLine();//this stores the response
            int TICK = Convert.ToInt32(number);//This converts the string to int

            Console.WriteLine("Are you qualified?");//This will suggest the reviewing of their answers to see if they are qualified.
            bool QUAL; //sets the value
            if (AGE > 15 && DUI == false && TICK <= 3)//This checks to confirm all 3 requirements are met. or else they say heck no!
            { 
                Console.WriteLine("Yes!");
                QUAL = true;
                Console.WriteLine(QUAL);
            }
            else
            { 
                Console.WriteLine("Heck no!");
                QUAL = false;
                Console.WriteLine(QUAL);
            }

            Console.ReadLine();
        }
    }
}
