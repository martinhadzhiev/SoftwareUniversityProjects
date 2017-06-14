using System.Linq;

namespace LettersChangeNumbers
{
    using System;

    class LettersChangeNumbers
    {
        public static string alphabetLower = ".abcdefghijklmnopqrstuvwxyz";
        public static string alphabetUpper = ".ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        static void Main()
        {
            var input = Console.ReadLine().Trim().Split(new []{' ','\t','\n','\r'},StringSplitOptions.RemoveEmptyEntries);

            var totalSum = 0.0;

            foreach (string s in input)
            {
                totalSum += CalculateStringSum(s);
            }

            Console.WriteLine($"{totalSum:F2}");
        }

        private static double CalculateStringSum(string s)
        {
            var char0 = s[0];
            var num = double.Parse(s.Substring(1, s.Length - 2));
            var char1 = s[s.Length - 1];

            if (char.IsUpper(char0))
            {
                num = num / alphabetUpper.IndexOf(char0);
            }
            else
            {
                num = num * alphabetLower.IndexOf(char0);
            }

            if (char.IsUpper(char1))
            {
                num -= alphabetUpper.IndexOf(char1);
            }
            else
            {
                num += alphabetLower.IndexOf(char1);
            }

            return num;
        }
    }
}
