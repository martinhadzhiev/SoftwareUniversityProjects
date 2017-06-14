using System.Collections.Generic;

namespace SpecialWords
{
    using System;
    using System.Linq;

    class SpecialWords
    {
        static void Main()
        {
            var specialWords = Console.ReadLine().Split();
            var wordCount = new Dictionary<string,int>();

            var text = Console.ReadLine()
                .Split(new[] {'(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' '},
                    StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var specialWord in specialWords)
            {
                wordCount.Add(specialWord,0);
            }

            foreach (var s in text)
            {
                if (wordCount.ContainsKey(s))
                {
                    wordCount[s]++;
                }
            }


            foreach (var word in wordCount)
            {
                Console.WriteLine($"{word.Key} - {word.Value}");
            }

        }
    }
}
