namespace UnicodeCharacters
{
    using System;
    using System.Collections.Generic;
    
    class UnicodeCharacters
    {
        static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            var unicodeChars = new List<string>();

            foreach (char c in input)
            {
                unicodeChars.Add(@"\u"+((int)c).ToString("X4").ToLower());
            }

            Console.WriteLine(string.Join("",unicodeChars));
        }
    }
}
