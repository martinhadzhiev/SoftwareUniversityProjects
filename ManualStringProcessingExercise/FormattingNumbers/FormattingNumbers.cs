namespace FormattingNumbers
{
    using System;
    using System.Linq;

    class FormattingNumbers
    {
        static void Main()
        {

            var inputArgs = Console.ReadLine()
                .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var a = int.Parse(inputArgs[0]);
            var b = double.Parse(inputArgs[1]);
            var c = double.Parse(inputArgs[2]);
            var aBinary = Convert.ToString(a, 2).PadLeft(10,'0');
            var aHex = Convert.ToString(a, 16).ToUpper();

            if (aBinary.Length > 10)
            {
                aBinary = aBinary.Remove(10);
            }

            Console.WriteLine(string.Format("|{0,-10}|{1,10}|{2,10:F2}|{3,-10:F3}|",aHex,aBinary, b, c));

        }
    }
}
