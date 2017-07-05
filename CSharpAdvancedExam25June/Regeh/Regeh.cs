using System.Collections.Generic;
using System.Text;

namespace Regeh
{
    using System;
    using System.Text.RegularExpressions;

    class Regeh
    {
        static void Main()
        {
            var pattern = @"\[(?:[a-zA-Z0-9]+)<((?:\d+)REGEH(?:\d+))>(?:[a-zA-Z0-9]+)]";
            var regex = new Regex(pattern);

            var line = Console.ReadLine();

            var matches = regex.Matches(line);

            var nums = new List<int>();

            foreach (Match match in matches)
            {
                var numberMatch = Regex.Matches(match.Groups[1].Value, @"\d+");

                foreach (Match nmatch in numberMatch)
                {
                    nums.Add(int.Parse(nmatch.Value));
                }
            }

            var currentNum = 0;

            var result = new StringBuilder();


            foreach (var n in nums)
            {
                currentNum += n;
                while (currentNum >= line.Length)
                {
                    currentNum -= line.Length - 1;
                }
                result.Append(line[currentNum]);
            }

            Console.WriteLine(result.ToString());

        }
    }
}
