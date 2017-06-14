using System.Numerics;
using System.Text;

namespace ConvertFromBase10ToBaseN
{
    using System;

    class ConvertFromBase10ToBaseN
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            var nBase = int.Parse(input[0]);
            var value = BigInteger.Parse(input[1]);

            Console.WriteLine(Encode(value,nBase));
        }


        public static string Encode(BigInteger value, int @base = 0, string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ")
        {
            if (@base <= 0) @base = chars.Length;
            var sb = new StringBuilder();
            do
            {
                int m = (int)(value % @base);
                sb.Insert(0, chars[m]);
                value = (value - m) / @base;
            } while (value > 0);
            return sb.ToString();
        }
    }
}
