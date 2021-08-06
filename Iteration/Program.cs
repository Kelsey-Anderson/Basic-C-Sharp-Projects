using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //    {
        //        if (testScores[i] > 85)
        //        {
        //    Console.WriteLine("Passing test score: " + testScores[i]);
        //        }
        //    }
        //    Console.ReadLine();

        //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    Console.WriteLine(names[j]); // lists out them all
        //}
        //Console.ReadLine();



        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);

        //foreach (int score in testScores) //Foreach loop
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + score);
        //    }

        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

        //foreach (string name in names)
        //{
        //    if (name == "Jesse")
        //    {
        //        Console.WriteLine(name);  // take out the if and it will list all names
        //    }
        //}
        //Console.ReadLine();

        List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };

        List<int> passingScores = new List<int>(); // creating a list with NOTHING inside of it currently

        foreach(int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score); // adds passing scores to the empty list
            }
        }

        Console.WriteLine(passingScores.Count); //this will tell how many are in list
        Console.ReadLine();


    }
    }

