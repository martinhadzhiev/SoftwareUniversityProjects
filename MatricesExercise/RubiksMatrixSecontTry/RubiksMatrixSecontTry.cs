namespace RubiksMatrixSecontTry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RubiksMatrixSecontTry
    {
        static void Main()
        {
            var inputArgs = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var commandsCount = int.Parse(Console.ReadLine());
            var rubiks = new int[inputArgs[0]][];

            for (int row = 0, counter = 1; row < rubiks.Length; row++)
            {
                rubiks[row] = new int[inputArgs[1]];

                for (int col = 0; col < rubiks[row].Length; col++, ++counter)
                {
                    rubiks[row][col] = counter;
                }
            }

            for (int commandIndex = 0; commandIndex < commandsCount; commandIndex++)
            {
                var inputTokens = Console.ReadLine()
                    .Split(' ');
                var selectedIndex = int.Parse(inputTokens[0]);
                var command = inputTokens[1];
                var rollTimes = int.Parse(inputTokens[2]);

                switch (command)
                {
                    case "up":
                    {
                        var queue = new Queue<int>();

                        for (int rowIndex = 0; rowIndex < rubiks.Length; rowIndex++)
                        {
                            queue.Enqueue(rubiks[rowIndex][selectedIndex]);
                        }

                        for (int i = 0; i < rollTimes % rubiks.Length; i++)
                        {
                            var number = queue.Dequeue();
                            queue.Enqueue(number);
                        }

                        for (int rowIndex = 0; rowIndex < rubiks.Length; rowIndex++)
                        {
                            rubiks[rowIndex][selectedIndex] = queue.Dequeue();
                        }

                        break;
                    }
                    case "down":
                    {
                        var queue = new Queue<int>();

                        for (int rowIndex = rubiks.Length - 1; rowIndex >= 0; rowIndex--)
                        {
                            queue.Enqueue(rubiks[rowIndex][selectedIndex]);
                        }

                        for (int i = 0; i < rollTimes % rubiks.Length; i++)
                        {
                            var number = queue.Dequeue();
                            queue.Enqueue(number);
                        }

                        for (int rowIndex = rubiks.Length - 1; rowIndex >= 0; rowIndex--)
                        {
                            rubiks[rowIndex][selectedIndex] = queue.Dequeue();
                        }

                        break;
                    }
                    case "left":
                    {
                        for (int i = 0; i < rollTimes % rubiks[selectedIndex].Length; i++)
                        {
                            var first = rubiks[selectedIndex][0];
                            Array.Copy(rubiks[selectedIndex], 1, rubiks[selectedIndex], 0,
                                rubiks[selectedIndex].Length - 1);
                            rubiks[selectedIndex][rubiks[selectedIndex].Length - 1] = first;
                        }

                        break;
                    }
                    case "right":
                    {
                        for (int i = 0; i < rollTimes % rubiks[selectedIndex].Length; i++)
                        {
                            var last = rubiks[selectedIndex][rubiks[selectedIndex].Length - 1];
                            Array.Copy(rubiks[selectedIndex], 0, rubiks[selectedIndex], 1,
                                rubiks[selectedIndex].Length - 1);
                            rubiks[selectedIndex][0] = last;
                        }

                        break;
                    }
                }
            }

            for (int row = 0, previous = 0; row < rubiks.Length; row++)
            {
                for (int col = 0; col < rubiks[0].Length; col++, ++previous)
                {
                    if (rubiks[row][col] - 1 == previous)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int nestedRow = row; nestedRow < rubiks.Length; nestedRow++)
                        {
                            var foundColumn = Array.IndexOf(rubiks[nestedRow], previous + 1);

                            if (foundColumn >= 0)
                            {
                                rubiks[nestedRow][foundColumn] = rubiks[row][col];
                                rubiks[row][col] = previous + 1;
                                Console.WriteLine($"Swap ({row}, {col}) with ({nestedRow}, {foundColumn})");
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}