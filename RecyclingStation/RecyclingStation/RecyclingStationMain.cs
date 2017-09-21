namespace RecyclingStation
{
    using Core;
    using Contracts;
    using Entities.IO;

    public class RecyclingStationMain
    {
        public static void Main()
        {
            IReader consoleReader = new ConsoleReader();
            IWriter consoleWriter = new ConsoleWriter();

            IEngine engine = new Engine(consoleReader, consoleWriter);
            engine.Run();
        }
    }
}
