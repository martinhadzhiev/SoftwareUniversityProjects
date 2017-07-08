namespace _03.Mankind
{
    using System;

    class Startup
    {
        static void Main()
        {
            var studentInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var workerInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                var student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
                var worker = new Worker(workerInfo[0],
                    workerInfo[1],
                    decimal.Parse(workerInfo[3]),
                    decimal.Parse(workerInfo[2]));

                Console.WriteLine(student);
                Console.WriteLine(worker);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
