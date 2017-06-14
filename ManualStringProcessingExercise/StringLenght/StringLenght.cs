namespace StringLenght
{
    using System;
    using System.Text;
    
    class StringLenght
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            if (input.Length >= 20)
            {
                for (int i = 0; i < 20; i++)
                {
                    sb.Append(input[i]);
                }
            }
            else
            {
                sb.Append(input);
                for (int i = 0; i < 20 - input.Length; i++)
                {
                    sb.Append("*");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
