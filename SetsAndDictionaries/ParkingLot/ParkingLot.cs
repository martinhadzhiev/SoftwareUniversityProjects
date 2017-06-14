using System.Collections.Generic;

namespace ParkingLot
{
    using System;

    class ParkingLot
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new []{ ',', ' ' },StringSplitOptions.RemoveEmptyEntries);
            var set = new SortedSet<string>();

            while (input[0]!="END")
            {
                var command = input[0];
                var numberPlate = input[1];

                switch (command)
                {
                    case "IN":
                        set.Add(numberPlate);
                        break;
                    case "OUT":
                        set.Remove(numberPlate);
                        break;
                    default:
                        Console.WriteLine("Wrong command!");
                        break;
                }

                input = Console.ReadLine().Split(new[] { ',',' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            if (set.Count > 0 )
            {
                foreach (string plate in set)
                {
                    Console.WriteLine(plate);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
