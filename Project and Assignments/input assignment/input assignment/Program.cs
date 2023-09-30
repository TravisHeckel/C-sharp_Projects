using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace input_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = DateTime.Now; //this gets the current date
            Console.WriteLine("The current time is " + date1); //this prints the current time

            Console.WriteLine("please type a number in."); //asks for input
            // string answer = Console.ReadLine(); //records input
            int answer = Convert.ToInt32(Console.ReadLine()); //records input

            DateTime future = date1.AddHours(answer);  //this changes the user input to datetime and adds it on as hours to date1
            Console.WriteLine("It will be " + future + " ," + answer + " hours from now.");//this confirms it by printing to console.


            //using (StreamWriter file = new StreamWriter(@"C:\Users\theck\Documents\Repositories\GitHub\Basic_C-Sharp_Projects\Project and Assignments\input assignment\log.txt", true)) //uses streamwriter to append another text or int to the file
            //{
            //    file.WriteLine(answer); //this is where they pull in the response      
            //}

            //string response; ///empty variable to be used
            //using (StreamReader file = new StreamReader(@"C:\Users\theck\Documents\Repositories\GitHub\Basic_C-Sharp_Projects\Project and Assignments\input assignment\log.txt")) //Streamreader will pull whatever data we need form the file
            //{
            //    response = file.ReadLine(); //this starts the reading

            //    while (response != null) //this makes sure it keeps going until all text is read
            //    {
                    
            //        Console.WriteLine(response);//write the line to console window
            //        response = file.ReadLine(); //Read the next line
            //    }
            //}

            Console.ReadLine();
        }
    }
}
