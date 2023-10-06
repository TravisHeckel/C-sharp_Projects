using System;

namespace Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter in your first Name");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\theck\Documents\Repositories\GitHub\Basic_C-Sharp_Projects\Lesson Examples\Score\Score\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double tScore = 0.0;

            Console.WriteLine("\nStudent Scores: \n");
            foreach (string line in lines)
            {
                Console.WriteLine("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score: " + avgScore);
            Console.WriteLine("\n\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
