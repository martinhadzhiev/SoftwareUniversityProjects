namespace School_Competition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, int> studentScores = new Dictionary<string, int>();
            Dictionary<string, SortedSet<string>> studentSubjects =
                new Dictionary<string, SortedSet<string>>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] personInfo = input.Split();
                string name = personInfo[0];
                string subject = personInfo[1];
                int score = int.Parse(personInfo[2]);

                if (!studentScores.ContainsKey(name) || !studentSubjects.ContainsKey(name))
                {
                    studentScores[name] = 0;
                    studentSubjects[name] = new SortedSet<string>();
                }

                studentScores[name] += score;
                studentSubjects[name].Add(subject);
            }

            foreach (KeyValuePair<string, int> kvp in studentScores
                .OrderByDescending(s => s.Value)
                .ThenBy(s => s.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} [{string.Join(", ",studentSubjects[kvp.Key])}]");
            }
        }
    }
}
