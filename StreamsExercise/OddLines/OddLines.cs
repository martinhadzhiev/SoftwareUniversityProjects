namespace OddLines
{
    using System;
    using System.IO;

    class OddLines
    {
        static void Main()
        {
            Console.WriteLine("Write file path:");
            var filePath = Console.ReadLine();

            var reader = new StreamReader(filePath);
            using (reader)
            {
                string line = reader.ReadLine();
                var counter = 0;
                while (line != null)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    line = reader.ReadLine();
                    counter++;
                }
            }
        }
    }
}
