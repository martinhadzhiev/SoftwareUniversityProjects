using System.Linq;

namespace StudentsByAge
{
    using System;
    using System.Collections.Generic;
    
    class StudentsByAge
    {
        static void Main()
        {
            var students = new Dictionary<string,int>();
            var line = Console.ReadLine();

            while (line != "END")
            {
                var studentArgs = line.Trim().Split();
                var names = string.Concat(studentArgs[0], " ", studentArgs[1]);
                var age = int.Parse(studentArgs[2]);

                students.Add(names,age);
                line = Console.ReadLine();
            }

            foreach (var student in students.Where(s => s.Value >= 18 && s.Value <= 24))
            {
                Console.WriteLine($"{student.Key} {student.Value}");
            }
        }
    }
}
