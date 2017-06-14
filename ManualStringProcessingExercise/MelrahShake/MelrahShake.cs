namespace MelrahShake
{
    using System;

    class MelrahShake
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (true)
            {
                var remove0 = text.IndexOf(pattern);
                if (remove0 == -1 || remove0 == text.LastIndexOf(pattern))
                {
                    break;
                }
                text = text.Remove(remove0, pattern.Length);

                var remove1 = text.LastIndexOf(pattern);
                if (remove1 == -1)
                {
                    break;
                }
                text = text.Remove(remove1, pattern.Length);

                Console.WriteLine("Shaked it.");


                pattern = pattern.Remove(pattern.Length / 2, 1);
                if (pattern.Length<=0)
                {
                    break;
                }

            }

            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}
