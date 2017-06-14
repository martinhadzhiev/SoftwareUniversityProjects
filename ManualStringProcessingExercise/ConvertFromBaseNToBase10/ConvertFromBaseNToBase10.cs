namespace ConvertFromBaseNToBase10
{
    using System;
    using System.Linq;
    using System.Numerics;

    class ConvertFromBaseNToBase10
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            int nBase = int.Parse(input[0]);
            string num = string.Join("", input[1].ToCharArray().Reverse());

            BigInteger numInBase10 = 0;

            int count = -1;

            for (int i = 0; i < num.Length; i++)
            {
                numInBase10 += BigInteger.Pow(nBase, ++count) * BigInteger.Parse(num[i].ToString());
            }

            Console.WriteLine(numInBase10);
        }
    }
}
