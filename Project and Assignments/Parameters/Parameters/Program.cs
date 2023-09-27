using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee<string> instance = new Employee<string>(); //create instance of employee
            instance.Things = new List<string>() { "fry", "nugget", "beef", "celery" }; //creating list in instance


            foreach (string word in instance.Things) //cycling thru list and printing off each item
            {
                Console.WriteLine(word);
            }
            
            Employee<int> instance2 = new Employee<int>(); //create instance of employee
            instance2.Things = new List<int>() { 1, 2, 3, 4 }; //creating list in instance

            foreach (int number in instance2.Things)  //cycling thru list and printing off each item
            {
                Console.WriteLine(number);
            }
      

            Console.ReadLine();
        }
    }
}
