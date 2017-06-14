using System.Collections.Generic;
using System.Linq;

namespace WordCount
{
    using System;
    using System.IO;

    class WordCount
    {
        static void Main()
        {
            Console.WriteLine("Write words text file path:");
            var wordsPath = Console.ReadLine();
            Console.WriteLine("Write text file path:");
            var textPath = Console.ReadLine();
            Console.WriteLine("Write result file path:");
            var resultPath = Console.ReadLine();

            var wordReader = new StreamReader(wordsPath);
            var textReader = new StreamReader(textPath);
            var writer = new StreamWriter(resultPath);

            var words = new Dictionary<string,int>();

            using (wordReader)
            {
                var word = wordReader.ReadLine();
                while (word != null)
                {
                    words.Add(word,0);
                    word = wordReader.ReadLine();
                }
            }

            using (textReader)
            {
                var line = textReader.ReadLine();
                while (line != null)
                {
                    var sentance = line
                        .ToLower()
                        .Split(new[] {' ', ',', '.', '-', '!', '?'}, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    foreach (var s in sentance)
                    {
                        if (words.ContainsKey(s))
                        {
                            words[s]++;
                        }
                    }

                    line = textReader.ReadLine();
                }
            }

            using (writer)
            {
                foreach (var word in words)
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }

            //C:\Users\Мартин Хаджиев\Desktop
        }
    }
}
