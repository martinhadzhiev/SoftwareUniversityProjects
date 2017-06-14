namespace CountUppercaseWords
{
    using System;
    using System.Linq;

    class CountUppercaseWords
    {
        static void Main()
        {
            Console.WriteLine(string.Join("\n\r",Console.ReadLine()
                .Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
                .Where(n => char.IsUpper(n[0]))
                .ToList()));
        }
    }
}
