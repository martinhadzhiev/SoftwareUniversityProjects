using System.Collections.Generic;

namespace SoftUniParty
{
    using System;

    class SoftUniParty
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var vipGusets = new SortedSet<string>();
            var normalGuests = new SortedSet<string>();
            bool partyStarted = false;

            while (input != "END")
            {
                if (input == "PARTY")
                {
                    partyStarted = true;
                }

                if (!partyStarted && char.IsDigit(input[0]))
                {
                    vipGusets.Add(input);
                }
                else if (!partyStarted && char.IsLetter(input[0]))
                {
                    normalGuests.Add(input);
                }
                else if (partyStarted && char.IsDigit(input[0]))
                {
                    vipGusets.Remove(input);
                }
                else if (partyStarted && char.IsLetter(input[0]))
                {
                    normalGuests.Remove(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(vipGusets.Count+normalGuests.Count);

            foreach (string guest in vipGusets)
            {
                Console.WriteLine(guest);
            }
            foreach (string guest in normalGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
