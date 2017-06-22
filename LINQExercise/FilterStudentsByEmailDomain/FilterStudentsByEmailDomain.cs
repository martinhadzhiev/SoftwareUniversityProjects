namespace FilterStudentsByEmailDomain
{
    using System;
    using System.Linq;

    class FilterStudentsByEmailDomain
    {
        static void Main()
        {
            var line = Console.ReadLine();

            while (line != "END")
            {
                if (line.Trim().Split().Skip(2).FirstOrDefault().EndsWith("@gmail.com"))
                {
                    Console.WriteLine(string.Join(" ",line.Trim().Split().Take(2).ToArray()));
                }
                line = Console.ReadLine();
            }
        }
    }
}
