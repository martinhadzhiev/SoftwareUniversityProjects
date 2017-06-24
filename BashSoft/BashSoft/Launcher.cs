namespace BashSoft
{
    using System;

    class Launcher
    {
        static void Main(string[] args)
        {
            //IOManager.TraverseDirectory(@"C:\Users\Мартин Хаджиев\Documents\Visual Studio 2017\Projects\BashSoft");

            //StudentsRepository.InitializeData();
            //StudentsRepository.GetAllStudentsFromCourse("Unity");
            //StudentsRepository.GetStudentScoresFromCourse("Unity", "Ivan");

            //Tester.CompareContent(@"C:\Users\Мартин Хаджиев\Desktop\test1.txt", @"C:\Users\Мартин Хаджиев\Desktop\test2.txt");

            //IOManager.CreateDirectoryInCurrentFolder("pesho");

            //IOManager.ChangeCurrentDirectoryAbsolute(@"C:\Windows");
            //IOManager.TraverseDirectory(20);

            InputReader.StartReadingCommands();

        }
    }
}
