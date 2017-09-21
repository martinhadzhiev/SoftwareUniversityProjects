using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var command = Console.ReadLine();
        var cmdArgs = command.Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

        Stack<string> stack = new Stack<string>();

        while (cmdArgs[0] != "END")
        {
            switch (cmdArgs[0])
            {
                case "Push":
                    string[] items = cmdArgs.Skip(1).ToArray();
                    stack.Push(items);
                    break;

                case "Pop":
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
            }

            command = Console.ReadLine();
            cmdArgs = command.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        }

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}