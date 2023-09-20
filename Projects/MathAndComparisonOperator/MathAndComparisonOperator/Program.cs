using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            //------------------------First Employee---------------------------------------------------
            Console.WriteLine("What is the first employee's name?"); //This identifies the employee
            string firstName = Console.ReadLine(); //accepts user input

            Console.WriteLine("How much does " + firstName + " make per hour?"); //This requests the income per hour
            string firstIncomeA = Console.ReadLine(); //This saves the input
            decimal firstIncomeB = Convert.ToDecimal(firstIncomeA); //this converts the input to decimal.

            Console.WriteLine("How many hours does  " + firstName + " work each week?"); //This request the hours worked each week
            string firstHoursA = Console.ReadLine();//This saves the input
            decimal firstHoursB = Convert.ToDecimal(firstHoursA);//this converts the input to decimal.


            //-----------------------Second Employee------------------------------------------------
            Console.WriteLine("What is the second employee's name?"); //This identifies the employee
            string secondName = Console.ReadLine(); //accepts user input

            Console.WriteLine("How much does " + secondName + " make per hour?"); //This requests the income per hour
            string secondIncomeA = Console.ReadLine(); //This saves the input
            decimal secondIncomeB = Convert.ToDecimal(secondIncomeA); //this converts the input to decimal.

            Console.WriteLine("How many hours does  " + secondName + " work each week?"); //This request the hours worked each week
            string secondHoursA = Console.ReadLine();//This saves the input
            decimal secondHoursB = Convert.ToDecimal(secondHoursA);//this converts the input to decimal.


            //------------------Salary of each employee-----------------------------------------------
            decimal firstSalary = (firstIncomeB * firstHoursB) * 52; //This takes the income multiplied by the hours and then by 52 weeks in a year.
            Console.WriteLine("The annual salary of " + firstName + ": $" + firstSalary); //This prints how much they make salary wise.

            decimal secondSalary = (secondIncomeB * secondHoursB) * 52; //This takes the income multiplied by the hours and then by 52 weeks in a year.
            Console.WriteLine("The annual salary of " + secondName + ": $" + secondSalary); //This prints how much they make salary wise.

            //-----------------comparison equation ----------------------------------------------------

            bool answer = firstSalary > secondSalary;

            Console.WriteLine("Does " + firstName + " make more money than " + secondName + "?"); //this prints the question
            Console.WriteLine("\n" + answer); //this prints the answer based on the if statment above



            Console.ReadLine(); //this shares everything typed up.
        }
    }
}
