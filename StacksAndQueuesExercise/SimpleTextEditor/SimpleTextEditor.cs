namespace SimpleTextEditor
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    class SimpleTextEditor
    {
        static void Main()
        {
            int cmdCount = int.Parse(Console.ReadLine());
            Stack<string> lastStrings = new Stack<string>();
            string currentString = "";
            lastStrings.Push(currentString);
            for (int i = 0; i < cmdCount; i++)
            {
                string[] commandArgs =
                    Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                switch (commandArgs[0])
                {
                    case "1":
                        {
                            currentString += commandArgs[1];
                            lastStrings.Push(currentString);
                        }
                        break;
                    case "2":
                        {
                            int countOfLastEl = int.Parse(commandArgs[1]);
                            StringBuilder str = new StringBuilder();
                            currentString = currentString.Substring(0, currentString.Length - countOfLastEl);
                            lastStrings.Push(currentString);

                        }
                        break;
                    case "3":
                        {

                            int indexForPrint = int.Parse(commandArgs[1]);
                            Console.WriteLine(currentString[indexForPrint - 1]);

                        }
                        break;
                    case "4":
                        {
                            lastStrings.Pop();
                            currentString = lastStrings.Peek();

                        }
                        break;

                }
            }
        }
    }
}
