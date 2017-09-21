namespace InfernoInfinity
{
    using Repository;

    public class StartUp
    {
        static void Main()
        {
            WeaponRepository weaponRepository = new WeaponRepository();
            CommandManager manager = new CommandManager(weaponRepository);
            CommandParser parser = new CommandParser(manager);

            parser.Run();
        }
    }
}
