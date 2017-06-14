using System.Collections.Generic;
using System.Linq;

namespace AcademyGraduation
{
    using System;

    class AcademyGraduation
    {
        static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            var studentScores = new SortedDictionary<string,double[]>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string name = Console.ReadLine();
                double[] scores = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse).ToArray();

                studentScores.Add(name,scores);
            }

            foreach (KeyValuePair<string, double[]> kvp in studentScores)
            {
               Console.WriteLine($"{kvp.Key} is graduated with {kvp.Value.Average()}");
            }
        }
    }
}
