namespace WeakerStudents
{
    using System;
    using System.Linq;

    class WeakerStudents
    {
        static void Main()
        {
            var line = Console.ReadLine();

            while (line != "END")
            {
                int[] marks = line.Trim().Split().Skip(2).Select(int.Parse).ToArray();

                if (marks.Where(m => m <=3).Count() >= 2)
                {
                    Console.WriteLine(string.Join(" ",line.Trim().Split().Take(2)));
                }

                line = Console.ReadLine();
            }
        }
    }
}
