namespace ActionPrint
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class ActionPrint
    {
        static void Main()
        {
            Action<List<string>> printer = n => n.ForEach(s => Console.WriteLine(s));
            var list = Console.ReadLine().Split().ToList();

            printer(list);
        }
    }
}
