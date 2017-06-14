namespace CharacterMultiplier
{
    using System;

    class CharacterMultiplier
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();

            Console.WriteLine(CharacterMultiply(input));
        }

        private static int CharacterMultiply(string[] input)
        {
            var string0 = input[0];
            var string1 = input[1];
            var sum = 0;

            for (int i = 0; i < Math.Min(string0.Length, string1.Length); i++)
            {
                sum += (int)string0[i] * (int)string1[i];
            }

            if (string0.Length > string1.Length)
            {
                for (int i = string1.Length; i < string0.Length; i++)
                {
                    sum += (int)string0[i];
                }
            }
            else if (string1.Length > string0.Length)
            {
                for (int i = string0.Length; i < string1.Length; i++)
                {
                    sum += (int)string1[i];
                }
            }

            return sum;
        }
    }
}
