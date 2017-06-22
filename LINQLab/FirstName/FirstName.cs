using System.Linq;

namespace FirstName
{
    using System;

    class FirstName
    {
        static void Main()
        {
            var names = Console.ReadLine().Split();
            var letters = Console.ReadLine().Split().OrderBy(l => l);

            foreach (var letter in letters)
            {
                var result = names.FirstOrDefault(n => n.ToLower().StartsWith(letter.ToLower()));
                if (result != null)
                {
                    Console.WriteLine(result);
                    return;
                }
            }
            Console.WriteLine("No match");

        }
    }
}
