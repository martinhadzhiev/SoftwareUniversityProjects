using System.Collections.Generic;
using System.Threading;

namespace FixEmails
{
    using System;

    class FixEmails
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var emailDictionary = new Dictionary<string,string>();
            int count = 0;

            while (input!= "stop")
            {
                if (count % 2 == 0)
                {
                    var email = Console.ReadLine();
                    if (!email.ToLower().EndsWith("uk") && !email.ToLower().EndsWith("us"))
                    {
                        emailDictionary[input] = email;
                    }
                }
                else
                {
                    input = Console.ReadLine();
                }
                count++;
            }

            foreach (KeyValuePair<string, string> kvp in emailDictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
