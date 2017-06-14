namespace MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;
    
    class MagicExchangeableWords
    {
        static void Main()
        {
            var input = Console.ReadLine().Trim().Split();
            var firstWord = new HashSet<char>(input[0]);
            var secondWord = new HashSet<char>(input[1]);

            if (firstWord.Count == secondWord.Count)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
