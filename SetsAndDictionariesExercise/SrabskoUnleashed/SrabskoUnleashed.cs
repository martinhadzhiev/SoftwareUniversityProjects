using System.Text;

namespace SrabskoUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SrabskoUnleashed
    {
        static void Main()
        {
            var venues = new Dictionary<string,Dictionary<string,int>>();
            var line = Console.ReadLine();

            while (line != "End")
            {
                var venueTokens = line.Split(new[] { " @" }, StringSplitOptions.RemoveEmptyEntries);

                if (!(venueTokens.Length > 1))
                {
                    line = Console.ReadLine();
                    continue;
                }

                var singer = venueTokens[0];
                var venueAndTickets = venueTokens[1].Split(' ');

                int ticketPrice = 0, ticketCount = 0;

                try
                {
                    ticketPrice = int.Parse(venueAndTickets[venueAndTickets.Length - 2]);
                    ticketCount = int.Parse(venueAndTickets[venueAndTickets.Length - 1]);
                }
                catch (Exception)
                {
                    line = Console.ReadLine();
                    continue;
                }

                var venue = new StringBuilder();

                for (int i = 0; i < venueAndTickets.Length - 2; i++)
                {
                    venue.Append(venueAndTickets[i]);
                    venue.Append(" ");
                }
                
                if (!venues.ContainsKey(venue.ToString()))
                {
                    venues.Add(venue.ToString(),new Dictionary<string, int>(){{singer,ticketCount*ticketPrice}});
                }
                else if (venues[venue.ToString()].ContainsKey(singer))
                {
                    venues[venue.ToString()][singer] += ticketCount * ticketPrice;
                }
                else
                {
                    venues[venue.ToString()].Add(singer,ticketCount*ticketPrice);
                }
               
                line = Console.ReadLine();
            }

            foreach (var venue in venues)
            {
                Console.WriteLine($"{venue.Key}");

                foreach (var singer in venue.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
