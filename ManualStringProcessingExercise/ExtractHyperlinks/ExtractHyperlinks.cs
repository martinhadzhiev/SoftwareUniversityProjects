using System.Linq;
using System.Text;

namespace ExtractHyperlinks
{
    using System;
    using System.Collections.Generic;


    class ExtractHyperlinks
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var hrefList = new List<string>();

            var sb = new StringBuilder();

            while (line != "END")
            {
                var lineArgs = line.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                sb.Append(string.Join("", lineArgs)+"\n");
                sb.Replace("ahref=\"", "start");
                line = Console.ReadLine();
            }

            Console.WriteLine(sb.ToString());

        }
    }
}
