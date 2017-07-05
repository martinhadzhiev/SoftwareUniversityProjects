using System.Linq;

namespace Hospital
{
    using System;
    using System.Collections.Generic;

    class Hospital
    {
        static void Main()
        {
            var departments = new List<Department>();

            var line = Console.ReadLine();

            while (line != "End")
            {
                var inputArgs = line.Trim().Split();
                var department = inputArgs[0];
                var doctor = inputArgs[1];
                var patient = inputArgs[2];

                if (!departments.Any(d => d.Name == department))
                {
                   
                }
            }
        }
    }
}
