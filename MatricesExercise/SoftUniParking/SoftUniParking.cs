namespace SoftUniParking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SoftUniParking
    {
        private static IDictionary<int, HashSet<int>> parking;
        private static int rows;
        private static int cols;

        public static void Main()
        {
            parking = new Dictionary<int, HashSet<int>>();
            string[] dimensions = Console.ReadLine().Split();
            rows = int.Parse(dimensions[0]);
            cols = int.Parse(dimensions[1]);

            string command = Console.ReadLine();
            while (command != "stop")
            {
                string[] commandArgs = command.Split();
                int entryRow = int.Parse(commandArgs[0]);
                int parkRow = int.Parse(commandArgs[1]);
                int parkCol = int.Parse(commandArgs[2]);

                if (IsSpotTaken(parkRow, parkCol))
                {
                    parkCol = FindAnotherSpot(parkRow, parkCol);
                }

                if (parkCol > 0)
                {
                    ParkAtSpot(parkRow, parkCol);

                    int distance = Math.Abs(parkRow - entryRow) + parkCol + 1;
                    Console.WriteLine(distance);
                }
                else
                {
                    Console.WriteLine($"Row {parkRow} full");
                }

                command = Console.ReadLine();
            }
        }

        private static int FindAnotherSpot(int row, int col)
        {
            int newCol = 0;
            int bestLength = int.MaxValue;
            for (int columnIndex = 1; columnIndex < cols; columnIndex++)
            {
                if (!IsSpotTaken(row, columnIndex))
                {
                    int newLength = Math.Abs(col - columnIndex);
                    if (newLength < bestLength)
                    {
                        bestLength = newLength;
                        newCol = columnIndex;
                    }
                }
            }

            return newCol;
        }

        private static bool IsSpotTaken(int row, int col)
        {
            return parking.ContainsKey(row) && parking[row].Contains(col);
        }

        private static void ParkAtSpot(int row, int col)
        {
            if (!parking.ContainsKey(row))
            {
                parking[row] = new HashSet<int>();
            }
            parking[row].Add(col);
        }
    }
}
