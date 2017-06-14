namespace TextFilter
{
    using System;
    using System.Linq;
    
    class TextFilter
    {
        static void Main()
        {
            var filters = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var text = Console.ReadLine();

            foreach (var filter in filters)
            {
                var replace = "".PadLeft(filter.Length, '*');
                text = text.Replace(filter, replace);
            }

            Console.WriteLine(text);
        }
    }
}
