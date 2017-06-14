namespace Palindromes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Palindromes
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] {' ', '.', ',', '!', '?', '[', ']', '{', '}', '(', ')'},
                    StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new HashSet<string>();

            foreach (var word in input)
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine($"[{string.Join(", ", palindromes.OrderBy(a => a))}]");
        }

        private static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length ; i++)
            {
                if (word[i] != word[word.Length- 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
