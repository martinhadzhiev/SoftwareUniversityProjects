namespace _1to100WithWords
{
    using System;

    class _1to100WithWords
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            var one = "one";
            var two = "two";
            var three = "three";
            var four = "four";
            var five = "five";
            var six = "six";
            var seven = "seven";
            var eight = "eight";
            var nine = "nine";

            if (number <= 10)
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine(one);
                        break;
                    case 2:
                        Console.WriteLine(two);
                        break;
                    case 3:
                        Console.WriteLine(three);
                        break;
                    case 4:
                        Console.WriteLine(four);
                        break;
                    case 5:
                        Console.WriteLine(five);
                        break;
                    case 6:
                        Console.WriteLine(six);
                        break;
                    case 7:
                        Console.WriteLine(seven);
                        break;
                    case 8:
                        Console.WriteLine(eight);
                        break;
                    case 9:
                        Console.WriteLine(nine);
                        break;
                    case 10:
                        Console.WriteLine("ten");
                        break;
                }
            }

            if (number > 10 && number < 20)
            {

            }
        }
    }
}
