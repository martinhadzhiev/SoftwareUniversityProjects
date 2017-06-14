using System.Collections.Generic;

namespace AppliedArithmetics
{
    using System;
    using System.Linq;

    class AppliedArithmetics
    {
        static void Main()
        {
            var nummberArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var command = Console.ReadLine();

            Func<int, int> addFunc = n => n = n + 1;
            Func<int, int> subtractFunc = n => n = n - 1;
            Func<int, int> multiplyFunc = n => n = n * 2;

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        nummberArray = SomeMethod(addFunc, nummberArray);
                        break;
                    case "multiply":
                        nummberArray = SomeMethod(multiplyFunc, nummberArray);
                        break;
                    case "subtract":
                        nummberArray = SomeMethod(subtractFunc, nummberArray);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nummberArray));
                        break;
                }
                command = Console.ReadLine();
            }
        }

        private static int[] SomeMethod(Func<int, int> function, int[] nummberArray)
        {
            for (int i = 0; i < nummberArray.Length; i++)
            {
                nummberArray[i] = function(nummberArray[i]);
            }

            return nummberArray;
        }

    }
}
