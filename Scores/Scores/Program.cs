﻿using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease enter your first name.");
            string date = DateTime.Today.ToLongDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\guita\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\Scores\Scores\testScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);


            double tScore = 0.0;

            Console.WriteLine("\nStudent Scores: \n");
            foreach(string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double aveScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage Score: " + aveScore);

            Console.WriteLine("\n\nPress and key to exit");
            Console.ReadKey();
        }
    }
}
