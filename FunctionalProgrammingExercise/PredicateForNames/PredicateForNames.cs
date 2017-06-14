namespace PredicateForNames
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class PredicateForNames
    {
        static void Main()
        {
            var lenght = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Predicate<string> lenghtCheck = n => n.Length <= lenght;

            CheckAndPrintNames(lenghtCheck, names);
        }

        private static void CheckAndPrintNames(Predicate<string> lenghtCheck, string[] names)
        {
            foreach (var name in names)
            {
                if (lenghtCheck(name))
                {
                    Console.WriteLine(name);
                }
            }

        }
    }
}
