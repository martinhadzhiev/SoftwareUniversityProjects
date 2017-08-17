public class StartUp
{
    public static void Main()
    {
        IInputReader reader = new ConsoleReader();
        IOutputWriter writer = new ConsoleWriter();
        HeroManager manager = new HeroManager();

        IEngine engine = new Engine(reader, writer, manager);
        engine.Run();
    }
}