using System.Linq;

namespace StudentsResults
{
    using System;

    class StudentsResults
    {
        static void Main()
        {
            var lineCount = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Format("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|","Name","CAdv","COOP","AdvOOP","Average"));
            for (int i = 0; i < lineCount; i++)
            {
                var line = Console.ReadLine().Split(new []{' ','-',','},StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = line[0];
                var cAdv = double.Parse(line[1]);
                var COOP = double.Parse(line[2]);
                var AdvOOP = double.Parse(line[3]);
                var avg = (cAdv + COOP + AdvOOP) / 3;


                Console.WriteLine(string.Format("{0,-10}|{1,7:F2}|{2,7:F2}|{3,7:F2}|{4,7:F4}|",name,cAdv,COOP,AdvOOP,avg));
            }
        }
    }
}
