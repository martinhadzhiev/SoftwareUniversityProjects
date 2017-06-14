namespace ConcatenateStrings
{
    using System;
    using System.Text;

    class ConcatenateStrings
    {
        static void Main()
        {
            var rows = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                var line = Console.ReadLine();
                sb.Append(line+" ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
