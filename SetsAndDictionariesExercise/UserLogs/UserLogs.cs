using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    using System;

    class UserLogs
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var users = new SortedDictionary<string, Dictionary<string, int>>();

            while (input[0] != "end")
            {
                var ip = input[0].Substring(3);
                var username = input[2].Substring(5);

                if (users.ContainsKey(username))
                {
                    if (users[username].ContainsKey(ip))
                    {
                        users[username][ip]++;
                    }
                    else
                    {
                        users[username][ip] = 1;
                    }
                }
                else
                {
                    users[username] = new Dictionary<string, int>(){{ip,1}};
                }

                input = Console.ReadLine().Split(' ');
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> user in users)
            {
                Console.WriteLine($"{user.Key}: ");
                Console.WriteLine("{0}.", string.Join(", ",user.Value.Select(a => $"{a.Key} => {a.Value}")));
            }
        }
    }
}
