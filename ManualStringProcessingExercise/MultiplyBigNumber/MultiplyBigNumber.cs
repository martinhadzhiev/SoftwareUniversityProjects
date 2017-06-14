using System.Linq;

namespace MultiplyBigNumber
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class MultiplyBigNumber
    {
        static void Main()
        {
            string number = Console.ReadLine().TrimStart(new char[] { '0' });
            byte miltiplier = byte.Parse(Console.ReadLine());

            if (number == "0" || miltiplier == 0 || number == "")
            {
                Console.WriteLine(0);
                return;
            }

            byte product = 0;
            byte numberInMind = 0;
            byte remainder = 0;
            StringBuilder result = new StringBuilder();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                product = (byte)(byte.Parse(number[i].ToString()) * miltiplier + numberInMind);
                numberInMind = (byte)(product / 10);
                remainder = (byte)(product % 10);
                result.Append(remainder);
                if (i == 0 && numberInMind != 0)
                {
                    result.Append(numberInMind);
                }

            }

            char[] resultToCharArr = result.ToString().ToCharArray();
            Array.Reverse(resultToCharArr);
            Console.WriteLine(new string(resultToCharArr));
        }
    }
}
