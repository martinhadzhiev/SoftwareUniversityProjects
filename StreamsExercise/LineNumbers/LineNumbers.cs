namespace LineNumbers
{
    using System;
    using System.IO;

    class LineNumbers
    {
        static void Main()
        {
            Console.WriteLine("Write read file path:");
            var filePath = Console.ReadLine();
            Console.WriteLine("Write result file path:");
            var resultPath = Console.ReadLine();

            var reader = new StreamReader(filePath);
            var writer = new StreamWriter(resultPath);

            using (reader)
            {
                using (writer)
                {
                    var counter = 1;
                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        writer.WriteLine($"Line {counter}: {line}");
                        line = reader.ReadLine();
                        counter++;
                    }
                }
            }
        }
    }
}
