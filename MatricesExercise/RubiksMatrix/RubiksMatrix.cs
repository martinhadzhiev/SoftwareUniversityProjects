namespace RubiksMatrix
{
    using System;
    using System.Linq;


    class RubiksMatrix
    {
        static void Main()
        {
            var rowsAndCols = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var numCmd = int.Parse(Console.ReadLine());

            long[][] cube = new long[rowsAndCols[0]][];

            long count = 1;
            for (int i = 0; i < rowsAndCols[0]; i++)
            {
                cube[i] = new long[rowsAndCols[1]];
                for (int j = 0; j < rowsAndCols[1]; j++)
                {
                    cube[i][j] = count;
                    count++;
                }
            }

            MovingMethod(numCmd, cube);

            var counter = 1;

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube[i].Length; j++)
                {
                    if (cube[i][j] == counter)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        int numRow = 0;
                        int numCol = 0;

                        for (int k = 0; k < cube.GetLength(0); k++)
                        {
                            for (int l = 0; l < cube[k].Length; l++)
                            {
                                if (cube[k][l] == counter)
                                {
                                    numRow = k;
                                    numCol = l;
                                    break;
                                }
                            }
                        }
                        var swapNum = cube[i][j];
                        cube[i][j] = cube[numRow][numCol];
                        cube[numRow][numCol] = swapNum;
                        Console.WriteLine($"Swap ({i}, {j}) with ({numRow}, {numCol})");
                    }

                    counter++;
                }
            }

        }

        private static void MovingMethod(int numCmd, long[][] cube)
        {
            for (int i = 0; i < numCmd; i++)
            {
                var command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (command[1])
                {
                    case "up":
                        for (int j = 0; j < int.Parse(command[2]); j++)
                        {
                            var col = int.Parse(command[0]);
                            var topmostElement = cube[0][col];

                            for (int k = 0; k < cube.GetLength(0) - 1; k++)
                            {
                                cube[k][col] = cube[k + 1][col];
                            }
                            cube[cube.GetLength(0) - 1][0] = topmostElement;
                        }
                        break;
                    case "down":
                        for (int j = 0; j < int.Parse(command[2]); j++)
                        {
                            var col = int.Parse(command[0]);
                            var lastElement = cube[cube.GetLength(0) - 1][col];

                            for (int k = cube.GetLength(0) - 1; k > 0; k--)
                            {
                                cube[k][col] = cube[k - 1][col];
                            }
                            cube[0][col] = lastElement;
                        }
                        break;
                    case "left":
                        for (int j = 0; j < int.Parse(command[2]); j++)
                        {
                            var row = int.Parse(command[0]);
                            var firstElement = cube[row][0];

                            for (int k = 0; k < cube[row].Length - 1; k++)
                            {
                                cube[row][k] = cube[row][k + 1];
                            }
                            cube[row][cube[row].Length - 1] = firstElement;
                        }
                        break;
                    case "right":
                        for (int j = 0; j < int.Parse(command[2]); j++)
                        {
                            var row = int.Parse(command[0]);
                            var lastElement = cube[row][cube[row].Length - 1];

                            for (int k = cube[row].Length - 1; k > 0; k--)
                            {
                                cube[row][k] = cube[row][k - 1];
                            }
                            cube[row][0] = lastElement;
                        }
                        break;
                }
            }
        }
    }
}
