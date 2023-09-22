using System;
using System.Collections.Generic;


namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {

            //---------example with int for looping thru an array---------------
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}

            //----- picking out specific strings-----------------
            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "Jesse")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}

            //----------------this prints out a list items individually---------------------------
            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(71);

            //foreach (int score in testScores) //score can be anything to represent each item
            //{
            //    Console.WriteLine("Passing test score:" + score);
            //}


            //---------------this prints a specific list item-----------------------------
            //List<string> names = new List<string>() { "Jesse", "Erik", "Daniel", "Adam" };

            //foreach (string name in names) //score can be anything to represent each item
            //{
            //    if (name == "Jesse")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}

            //---------------------------this adds item from one list to another---------------
            List<int> testScores = new List<int>() { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }

            Console.WriteLine(passingScores.Count); // this counts how many students passed 
            Console.ReadLine();
        }
    }
}
