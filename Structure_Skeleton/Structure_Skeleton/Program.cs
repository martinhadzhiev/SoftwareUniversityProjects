public class Program
{
    public static void Main()
    {
        IEnergyRepository energyRepository = new EnergyRepository();

        IHarvesterController harvesterController = new HarvesterController(energyRepository);
        IProviderController providerController = new ProviderController(energyRepository);

        ICommandInterpreter commandInterpreter = new CommandInterpreter(harvesterController,providerController);

        Engine engine = new Engine(commandInterpreter);
        engine.Run();
    }
}