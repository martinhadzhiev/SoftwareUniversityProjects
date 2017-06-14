namespace ParseURLs
{
    using System;
    using System.Linq;


    class ParseURLs
    {
        static void Main()
        {
            try
            {
                var url = Console.ReadLine().Split(new[] { "://" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (url.Length != 2)
                {
                    Console.WriteLine("Invalid URL");
                }
                else
                {
                    var protocol = url[0];
                    var server = url[1].Split('/').FirstOrDefault();
                    if (server == null)
                    {
                        Console.WriteLine("Invalid URL");
                        return;
                    }

                    var resources = url[1].Substring(server.Length + 1);

                    Console.WriteLine($"Protocol = {protocol}");
                    Console.WriteLine($"Server = {server}");
                    Console.WriteLine($"Resources = {resources}");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid URL");
            }
        }
    }
}
