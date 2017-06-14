using System.Collections.Generic;

namespace SlicingFile
{
    using System;
    using System.IO;

    class SlicingFile
    {
        static void Main()
        {
            using (FileStream source = new FileStream("source.txt", FileMode.Open))
            {

                Console.Write("How many parts ?");
                long partCount = long.Parse(Console.ReadLine());
                long sourceLen = source.Length;
                long lastBytesCount = source.Length / partCount;
                long lastPartCount = lastBytesCount + (source.Length % partCount);

                Console.Write("Slice or Assemble ? - ");
                string option = Console.ReadLine().ToLower();

                if (option.Equals("slice"))
                {

                    Slice(source, partCount, lastBytesCount, lastPartCount);
                }
                else if (option.Equals("assemble"))
                {
                    Assemble(partCount);
                }
            }
        }
        private static void Assemble(long partCount)
        {
            List<string> fileNames = new List<string>();
            for (int i = 0; i < partCount; i++)
            {
                fileNames.Add($"Part-{i}.txt");
            }

            try
            {
                using (FileStream resultFile = new FileStream("result.txt", FileMode.Create))
                {
                    for (int i = 0; i < fileNames.Count; i++)
                    {
                        FileStream currentFile = new FileStream($"{fileNames[i]}", FileMode.Open);
                        for (int j = 0; j < currentFile.Length; j++)
                        {
                            resultFile.WriteByte((byte)currentFile.ReadByte());
                        }
                        currentFile.Close();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Result file already exist! Delete it and run program again.");
            }

        }
        private static void Slice(FileStream source, long partCount, long bytesCount, long lastPartCount)
        {
            for (int i = 0; i < partCount; i++)
            {
                try
                {
                    using (FileStream writer = new FileStream($"Part-{i}.txt", FileMode.CreateNew))
                    {
                        if (i == partCount - 1)
                        {
                            for (int j = 0; j < lastPartCount; j++)
                            {
                                writer.WriteByte((byte)source.ReadByte());
                            }
                        }
                        else
                        {
                            for (int j = 0; j < bytesCount; j++)
                            {
                                writer.WriteByte((byte)source.ReadByte());
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Program found parts from source file! Delete these parts and try again");
                    break;
                }
            }
        }
    }
}
