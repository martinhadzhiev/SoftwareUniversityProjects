using System.Linq;

namespace FilterStudentsByPhone
{
    using System;

    class FilterStudentsByPhone
    {
        static void Main()
        {
            var line = Console.ReadLine();

            while (line != "END")
            {
                if (line.Trim().Split().Skip(2).FirstOrDefault().StartsWith("02") ||
                    line.Trim().Split().Skip(2).FirstOrDefault().StartsWith("+3592"))
                {
                    Console.WriteLine(string.Join(" ",line.Trim().Split().Take(2)));
                }

                line = Console.ReadLine();
            }
        }
    }
}
