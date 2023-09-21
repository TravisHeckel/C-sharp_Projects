using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \"I forgot what i wanted to say...\n \t well that doesnt matter anymore \".";
            //string fileName = @"C:\user\jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;
            //Console.WriteLine(length);

            //name = name.ToUpper();
            //name = name.ToLower();


            //Console.WriteLine(length);
            //---------------------I concatenate three strings --------------------
            string firstName = "travis";
            string middleName = "James";
            string lastName = "Heckel";
            Console.WriteLine(firstName + middleName + lastName);
            //----------------------Converted a string to uppercase---------------------
            string firsttry = firstName.ToUpper();
            Console.WriteLine(firsttry);

            //--------------------Creates a string builder and builds a a paragraph of text, one sentence at a time.--------------------
            StringBuilder sb = new StringBuilder();

            sb.Append("my Name is Travis Heckel!");
            sb.Append("I like food, and ");
            sb.Append("I hate heat.");
            sb.Append("I ran for president once.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
