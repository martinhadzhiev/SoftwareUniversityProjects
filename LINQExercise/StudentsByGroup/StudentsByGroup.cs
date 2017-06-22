using System.Linq;

namespace StudentsByGroup
{
    using System;
    using System.Collections.Generic;
    
    class StudentsByGroup
    {
        static void Main()
        {
            var list = new List<string>();
            var line = Console.ReadLine();

            while (line != "END")
            {
                var lineArgs = line.Trim().Split();
                var name = string.Concat(lineArgs[0], " ", lineArgs[1]).Trim();
                if (lineArgs[2] == "2")
                {
                    list.Add(name);
                }
                line = Console.ReadLine();
            }

            list.OrderBy(a => a).ToList().ForEach(e => Console.WriteLine(e));

        }
    }
}
