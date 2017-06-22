namespace StudentsByFirstAndLastName
{
    using System;

    class StudentsByFirstAndLastName
    {
        static void Main()
        {
            var line = Console.ReadLine();

            while (line != "END")
            {
                var names = line.Trim().Split();

                if (names[0].CompareTo(names[1]) == -1)
                {
                    Console.WriteLine(line);
                }
                line = Console.ReadLine();
            }
        }
    }
}
