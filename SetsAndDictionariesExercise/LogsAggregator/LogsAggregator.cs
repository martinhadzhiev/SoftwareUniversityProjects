using System.Collections.Generic;
using System.Linq;

namespace LogsAggregator
{
    using System;

    class LogsAggregator
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var usersIp = new SortedDictionary<string, SortedSet<string>>();
            var userDuration = new SortedDictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var inputArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var ip = inputArgs[0];
                var user = inputArgs[1];
                var duration = int.Parse(inputArgs[2]);

                if (!usersIp.ContainsKey(user))
                {
                    usersIp.Add(user,new SortedSet<string>(){{ip}});
                    userDuration.Add(user,duration);
                }
                else
                {
                    usersIp[user].Add(ip);
                    userDuration[user] += duration;
                }
            }

            foreach (var user in usersIp)
            {
                Console.WriteLine($"{user.Key}: {userDuration.FirstOrDefault(u=> u.Key == user.Key).Value} [{string.Join(", ",user.Value)}]");
            }
        }
    }
}
