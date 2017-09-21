using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        ListyIterator<List<string>> listyIterator = default(ListyIterator<List<string>>);

        var command = Console.ReadLine();
        var cmdArgs = command.Split();

        while (cmdArgs[0] != "END")
        {
            switch (cmdArgs[0])
            {
                case "Create":
                    string[] items = cmdArgs.Skip(1).ToArray();
                    listyIterator = new ListyIterator<List<string>>(items);
                    break;
                case "HasNext":
                    Console.WriteLine(listyIterator.HasNext());
                    break;
                case "Print":
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "Move":
                    Console.WriteLine(listyIterator.Move());
                    break;
                case "PrintAll":
                    Console.WriteLine(string.Join(" ",listyIterator.PrintAll()));
                    break;
            }

            command = Console.ReadLine();
            cmdArgs = command.Split();
        }
    }
}