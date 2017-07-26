namespace CutomList
{
    using System;

    class StartUp
    {
        static void Main()
        {
            MyList<string> list = new MyList<string>();

            var cmd = Console.ReadLine();

            while (cmd != "END")
            {
                var commandArgs = cmd.Split();

                switch (commandArgs[0])
                {
                    case "Add":
                        var element = commandArgs[1];
                        list.Add(element);
                        break;

                    case "Remove":
                        var index = int.Parse(commandArgs[1]);
                        list.Remove(index);
                        break;

                    case "Contains":
                        element = commandArgs[1];
                        Console.WriteLine(list.Contains(element));
                        break;

                    case "Swap":
                        var firstIndex = int.Parse(commandArgs[1]);
                        var secondIndex = int.Parse(commandArgs[2]);
                        list.Swap(firstIndex, secondIndex);
                        break;

                    case "Greater":
                        element = commandArgs[1];
                        Console.WriteLine(list.CountGreaterThan(element));
                        break;

                    case "Max":
                        Console.WriteLine(list.Max());
                        break;

                    case "Min":
                        Console.WriteLine(list.Min());
                        break;

                    case "Print":
                        foreach (var e in list)
                        {
                            Console.WriteLine(e);
                        }
                        break;

                    case "Sort":
                        list = Sorter.Sort(list);
                        break;
                }

                cmd = Console.ReadLine();
            }
        }
    }
}
