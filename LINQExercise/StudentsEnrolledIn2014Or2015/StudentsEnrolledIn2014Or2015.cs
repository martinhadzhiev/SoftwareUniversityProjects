namespace StudentsEnrolledIn2014Or2015
{
    using System;
    using System.Linq;

    class StudentsEnrolledIn2014Or2015
    {
        static void Main()
        {
            var line = Console.ReadLine();

            while (line != "END")
            {
                var marks = line.Trim().Split().Skip(1).ToArray();

                if (line.Trim().Split().FirstOrDefault()[4] == '1' &&
                    (line.Trim().Split().FirstOrDefault()[5] == '4' ||
                     line.Trim().Split().FirstOrDefault()[5] == '5')
                     )
                {
                    Console.WriteLine(string.Join(" ",marks));
                }

                line = Console.ReadLine();
            }
        }
    }
}
