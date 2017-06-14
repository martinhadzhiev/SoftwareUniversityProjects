using System.Linq;

namespace LegoBlocks
{
    using System;

    class LegoBlocks
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
          
            int[][] firtsJaggedArray = new int[n][];
            int[][] secondJaggedArray = new int[n][];

            for (int i = 0; i < n; i++)
            {
                firtsJaggedArray[i] = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            for (int i = 0; i < n; i++)
            {
                secondJaggedArray[i] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var match = false;

            for (int i = 0; i < n-1; i++)
            {
                if (firtsJaggedArray[i].Length + secondJaggedArray[i].Length ==
                    firtsJaggedArray[i+1].Length + secondJaggedArray[i+1].Length)
                {
                    match = true;
                }
                else
                {
                    var cells = 0;

                    for (int j = 0; j < n; j++)
                    {
                        cells += firtsJaggedArray[j].Length + secondJaggedArray[j].Length;
                    }

                    Console.WriteLine($"The total number of cells is: {cells}");
                    match = false;
                    return;
                }
            }

            if (match)
            {
                int[][] combined = new int[n][];

                for (int i = 0; i < n; i++)
                {
                    int[] array = firtsJaggedArray[i].Concat(secondJaggedArray[i].Reverse()).ToArray();
                    combined[i] = array;
                }

                foreach (var row in combined)
                {
                    Console.WriteLine($"[{string.Join(", ",row)}]");
                }
            }

           
            
        }
    }
}
