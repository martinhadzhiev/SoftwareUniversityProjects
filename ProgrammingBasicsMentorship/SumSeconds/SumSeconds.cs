namespace SumSeconds
{
    using System;

    class SumSeconds
    {
        static void Main()
        {
            int firstCompetior = int.Parse(Console.ReadLine());
            int secondCompetior = int.Parse(Console.ReadLine());
            int thirdCompetior = int.Parse(Console.ReadLine());

            int secondSum = firstCompetior + secondCompetior + thirdCompetior;

            if (secondSum < 60)
            {
                Console.WriteLine($"0:{secondSum:00}");
            }
            else if (secondSum < 120)
            {
                Console.WriteLine($"1:{secondSum - 60:00}");
            }
            else if (secondSum < 180)
            {
                Console.WriteLine($"2:{secondSum - 120:00}");
            }
            else
            {
                Console.WriteLine("3:00");
            }
        }
    }
}
