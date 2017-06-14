namespace CopyBinaryFile
{
    using System;
    using System.IO;

    class CopyBinaryFile
    {
        static void Main()
        {
            Console.WriteLine("Write file path:");
            var filePath = Console.ReadLine();
            Console.WriteLine("Write result file path:");
            var resultPath = Console.ReadLine();

            using (var source = new FileStream(filePath, FileMode.Open))
            {
                using (var destination = new FileStream(resultPath, FileMode.Create))
                {
                    double fileLenght = source.Length;
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        destination.Write(buffer, 0, readBytes);

                    }
                    Console.WriteLine($"File copied in {resultPath}");
                }
            }
        }
    }
}
