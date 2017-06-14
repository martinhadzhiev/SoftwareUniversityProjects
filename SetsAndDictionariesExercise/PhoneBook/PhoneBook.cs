using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    using System;

    class PhoneBook
    {
        static void Main()
        {
            var input = Console.ReadLine().Split('-');
            var phonebook = new Dictionary<string,string>();
            
            while (input[0]!= "search")
            {
                bool isValid = input.Count() == 2;

                if (isValid)
                {
                    phonebook[input[0]] = input[1];
                }
                input = Console.ReadLine().Split('-');
            }

            input = Console.ReadLine().Split('-');

            while (input[0]!= "stop")
            {
                if (phonebook.ContainsKey(input[0]))
                {
                    KeyValuePair<string,string> kvp = new KeyValuePair<string, string>();
                    

                    Console.WriteLine($"{input[0]} -> {phonebook[input[0]]}"); 
                }
                else
                {
                    Console.WriteLine($"Contact {input[0]} does not exist.");
                }
                input = Console.ReadLine().Split('-');
            }
        }
    }
}
