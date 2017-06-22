namespace InfernoIII
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class InfernoIII
    {
        private static List<int> numbers = new List<int>();
        static void Main()
        {
            numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine();
            var commands = new List<string>();

            while (command != "Forge")
            {
                if (command.StartsWith("Exclude")) commands.Add(command);
                if (command.StartsWith("Reverse"))
                {
                    var check = command.Replace("Reverse", "Exclude");
                    if (commands.Contains(check))
                    {
                        commands.Remove(check);
                    }
                }
                command = Console.ReadLine();
            }

            var valuesToRemove = new List<int>();


            foreach (var cmd in commands)
            {
                var c = cmd.Split(';').Skip(1).ToArray();
                var condition = c[0];
                var value = int.Parse(c[1]);


                switch (condition)
                {
                    case "Sum Left":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if ((i <= 0 ? 0 : numbers[i - 1]) + numbers[i] == value)
                            {
                                valuesToRemove.Add(numbers[i]);
                            }
                        }
                        break;

                    case "Sum Right":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] + (i >= numbers.Count - 1 ? 0 : numbers[i + 1]) == value)
                            {
                                valuesToRemove.Add(numbers[i]);
                            }
                        }
                        break;

                    case "Sum Left Right":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if ((i <= 0 ? 0 : numbers[i - 1]) + numbers[i] + (i >= numbers.Count - 1 ? 0 : numbers[i + 1]) == value)
                            {
                                valuesToRemove.Add(numbers[i]);
                            }
                        }
                        break;
                }

            }

            foreach (var value in valuesToRemove)
            {
                numbers.Remove(value);
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
