namespace QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;


    class QueryMess
    {
        static void Main()
        {
            var line = Console.ReadLine().Trim();
            var regex = new Regex(@"([^&=?\s]*)(?=\=)=(?<=\=)([^&=\s]*)");
            
            while (line != "END")
            {
                var keys = new Dictionary<string, List<string>>();
                var matches = regex.Matches(line);

                foreach (Match match in matches)
                {
                    var keyword = Regex.Replace(match.Groups[1].Value, @"(%20|\+)+", " ").Trim();
                    var value = Regex.Replace(match.Groups[2].Value, @"(%20|\+)+", " ").Trim();

                    if (keys.ContainsKey(keyword))
                    {
                        keys[keyword].Add(value);
                    }
                    else
                    {
                        keys.Add(keyword,new List<string>());
                        keys[keyword].Add(value);
                    }
                }

                foreach (var key in keys)
                {
                    Console.Write($"{key.Key}=[{string.Join(", ", key.Value)}]");
                }
                Console.WriteLine();
                
                line = Console.ReadLine();
            }

           
        }
    }
}
