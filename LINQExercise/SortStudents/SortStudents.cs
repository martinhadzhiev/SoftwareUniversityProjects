using System.Collections.Generic;
using System.Linq;

namespace SortStudents
{
    using System;

    class SortStudents
    {
        static void Main()
        {

            var line = Console.ReadLine();
            var students = new List<string>();

            while (line != "END")
            {
                students.Add(line);
                line = Console.ReadLine();
            }

            foreach (var s in students
                .OrderBy(s => s.Split().Skip(1).FirstOrDefault())
                .ThenByDescending(s => s.Split().FirstOrDefault())
                )
            {
                Console.WriteLine(s);
            }
        }
    }
}
