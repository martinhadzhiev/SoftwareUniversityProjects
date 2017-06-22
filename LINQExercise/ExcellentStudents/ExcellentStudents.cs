namespace ExcellentStudents
{
    using System;
    using System.Linq;

    class ExcellentStudents
    {
        static void Main()
        {
            var line = Console.ReadLine();

            while (line != "END")
            {
                if (line.Contains("6"))
                {
                    Console.WriteLine(string.Join(" ",line.Trim().Split().Take(2)));
                }
                line = Console.ReadLine();
            }
        }
    }
}
