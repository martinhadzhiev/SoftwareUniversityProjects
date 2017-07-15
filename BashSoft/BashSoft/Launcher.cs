namespace BashSoft
{
    using System;

    class Launcher
    {
        static void Main()
        {
            Tester tester = new Tester();
            IOManager ioManager = new IOManager();
            StudentRepository repository = new StudentRepository(new RepositoryFilter(), new RepositorySorter());

            CommandInterpreter interpreter = new CommandInterpreter(tester,repository,ioManager);
            InputReader reader = new InputReader(interpreter);

            reader.StartReadingCommands();
        }
    }
}
