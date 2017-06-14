using System.Collections.Generic;

namespace StringMatrixRotation
{
    using System;
    using System.Linq;

    class StringMatrixRotation
    {
        static void Main()
        {
            var rotation = Console.ReadLine().Split(new[] { '(', ')' }).Skip(1).FirstOrDefault();

            var input = Console.ReadLine();
            var matrix = new List<List<char>>();

            while (input != "END")
            {
                var line = input.ToCharArray();
                var list = new List<char>();
                list.AddRange(line);
                matrix.Add(list);
                input = Console.ReadLine();
            }

            var rMatrix = new List<List<char>>();

            switch (int.Parse(rotation) % 360)
            {
                case 0:
                    foreach (List<char> list in matrix)
                    {
                        Console.WriteLine(string.Join("", list));
                    }
                    break;

                case 90:
                    var col = 0;

                    var maxLenght = matrix.Max(c => c.Count);
                    while (true)
                    {
                        for (int row = matrix.Count - 1; row >= 0; row--)
                        {
                            try
                            {
                                Console.Write(matrix[row][col]);
                            }
                            catch (Exception)
                            {
                                Console.Write(' ');
                            }
                        }
                        Console.WriteLine();
                        col++;
                        if (col>=maxLenght)
                        {
                            break;
                        }
                    }
                    break;

                case 180:
                    for (int i = matrix.Count - 1; i >= 0; i--)
                    {
                        var line = matrix[i].ToArray().Reverse().ToArray();
                        var rList = new List<char>();
                        rList.AddRange(line);
                        rMatrix.Add(rList);
                    }

                    foreach (var row in rMatrix)
                    {
                        Console.WriteLine(string.Join("", row));
                    }
                    break;

                case 270:
                    var cols = matrix.Max(c => c.Count);

                    var maxCount = matrix.Max(c => c.Count);
                    while (true)
                    {
                        for (int row = 0; row < matrix.Count; row++)
                        {
                            try
                            {
                                Console.Write(matrix[row][cols]);
                            }
                            catch (Exception)
                            {
                                Console.Write(' ');
                            }
                        }
                        Console.WriteLine();
                        cols--;
                        if (cols <0)
                        {
                            break;
                        }
                    }
                    break;
            }
        }
    }
}
