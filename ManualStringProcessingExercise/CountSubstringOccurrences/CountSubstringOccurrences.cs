namespace CountSubstringOccurrences
{
    using System;

    class CountSubstringOccurrences
    {
        static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var s = Console.ReadLine().ToLower();

            var counter = 0;

            while (text.Length > 0)
            {
                try
                {
                    var curPart = text.Substring(0, s.Length);
                    if (curPart == s)
                    {
                        counter++;
                    }
                    text = text.Substring(1);
                }
                catch (Exception )
                {
                    Console.WriteLine(counter);
                    return;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
