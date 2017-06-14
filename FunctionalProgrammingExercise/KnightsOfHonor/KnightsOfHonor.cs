namespace KnightsOfHonor
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class KnightsOfHonor
    {
        static void Main()
        {
            Action<List<string>> printer = n => n.ForEach(s => Console.WriteLine($"Sir {s}"));
            var knights = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

            printer(knights);
        }
    }
}
