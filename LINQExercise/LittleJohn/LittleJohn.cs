using System.Text.RegularExpressions;

namespace LittleJohn
{
    using System;
    using System.Linq;

    class LittleJohn
    {
        public static int count = 4;

        static void Main()
        {
            var bigArrow = @">>>----->>";
            var mediumArrow = @">>----->";
            var smallArrow = @">----->";

            int bigCount = 0;
            int mediumCount = 0;
            int smallCount = 0;

            for (int i = 0; i < count; i++)
            {
                var line = Console.ReadLine();

               bigCount += Regex.Matches(line, bigArrow).Count;
                line = Regex.Replace(line, bigArrow, "ba");
               mediumCount += Regex.Matches(line, mediumArrow).Count;
                line = Regex.Replace(line, mediumArrow, "ba");
                smallCount += Regex.Matches(line, smallArrow).Count;
            }

            var arrows = int.Parse(string.Concat(smallCount, mediumCount, bigCount));

            var result = Convert.ToInt32(Convert.ToString(arrows, 2)+string.Join("", Convert.ToString(arrows, 2).Reverse()),2);

            Console.WriteLine(result);
        }
    }
}
