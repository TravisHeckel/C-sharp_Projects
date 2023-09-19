using System;


namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            //-------title for report-------------------------------------------------------------------------------
            Console.WriteLine("The Tech Academy" + '\n'); //This is the title
            Console.WriteLine('\n' + "Student Daily Report" + '\n');

            //------student name----------------------------------------------------------------------------------
            Console.WriteLine("What is your name?"); //This will ask your name
            string yourName = Console.ReadLine(); //This command will save what the user inputs.
            //Console.WriteLine("Your name is: " + yourName + '\n'); //I used this to confirm the correct answers are given.

            //-------chosen course------------------------------------------------------------------------------
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();//This command will save what the user inputs.
            //Console.WriteLine("Your current course is: " + course + '\n');//I used this to confirm the correct answers are given.

            //-------page number---------------------------------------------------------------------------------
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();//This command will save what the user inputs.
            int page = Convert.ToInt32(pageNumber);
            //Console.WriteLine("Your page number is: " + page  + '\n');//I used this to confirm the correct answers are given.


            //-----display help question-------------------------------------------------------------------------------------
            Console.WriteLine("Do you need help with anything?");
            Console.WriteLine("Please answer true or false");
            string answer = Console.ReadLine();//This command will save what the user inputs.
            string result = answer.ToLower();
            bool end = false;
            
            while (end != true)
            {


                if (result == "true" || result == "false")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please answer true or false");
                    result = Console.ReadLine();
                    result.ToLower();
                }
            }

            bool finalAnswer = Convert.ToBoolean(result);
            //I used this to confirm the correct answers are given.

            //if (finalAnswer == true) 
            //{
            //    Console.WriteLine("You respond with " + finalAnswer + " and a instructor will contact you shortly");
            //}
            //else
            //{
            //    Console.WriteLine("You respond with " + finalAnswer + ", keep up with the good work and have a wonderful day!");
            //}

            //------positive experiences shared----------------------------------------------------------------------------------
            Console.WriteLine("Were there any positive experiences you'd like to share?"); //This will ask for your input
            string experience = Console.ReadLine(); //This command will save what the user inputs.
            //Console.WriteLine("Your positive experience was: " + experience + '\n'); //I used this to confirm the correct answers are given.

            //------any feedback shared----------------------------------------------------------------------------------
            Console.WriteLine("Was there any feedback you would like to share?"); //This will ask about getting feedback?
            string feedback = Console.ReadLine(); //This command will save what the user inputs.
            //Console.WriteLine("Feedback: " + feedback + '\n'); //I used this to confirm the correct answers are given.

            //------hours worked----------------------------------------------------------------------------------
            Console.WriteLine("How many hours have you practiced today?" + '\n');
            Console.WriteLine("please only type a whole number. Do NOT type out the word.");
            string hoursWorked = Console.ReadLine();//This command will save what the user inputs.
            bool check = int.TryParse(hoursWorked, out _);

            while (check != true)
            {
                Console.WriteLine("please only type a whole number. Do NOT type out the word.");
                hoursWorked = Console.ReadLine();//This command will save what the user inputs.
            }
            int hour = Convert.ToInt32(hoursWorked);
            Console.WriteLine("Your hours today are  " + hour + '.' + '\n');  //I used this to confirm the correct answers are given.

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine(); //This displays all the information including questions.
        }
    }
}

