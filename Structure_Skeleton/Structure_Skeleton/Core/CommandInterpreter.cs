using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class CommandInterpreter : ICommandInterpreter
{
    private const string CommandSuffix = "Command";

    public CommandInterpreter(IHarvesterController harvesterController,
        IProviderController providerController)
    {
        this.HarvesterController = harvesterController;
        this.ProviderController = providerController;
    }

    public IHarvesterController HarvesterController { get; private set; }

    public IProviderController ProviderController { get; private set; }

    public string ProcessCommand(IList<string> args)
    {
        string commandName = args[0] + CommandSuffix;

        Type commandType = Assembly.GetExecutingAssembly().GetType(commandName);

        List<object> injectObjects = new List<object>()
        {
            args,this.HarvesterController,this.ProviderController
        };

        var commandParams = commandType.GetConstructors().FirstOrDefault().GetParameters().Where(p => p.ParameterType.Name.Contains("Controller")).ToList();

        IList<object> paramsToInject = new List<object>();

        paramsToInject.Add(args.Skip(1).ToList());

        foreach (ParameterInfo parameterInfo in commandParams)
        {
            paramsToInject.Add(this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).FirstOrDefault(f => f.FieldType.Name == parameterInfo.ParameterType.Name).GetValue(this));
        }

        ConstructorInfo commandCtor = commandType.GetConstructors().FirstOrDefault();

        ICommand command = (ICommand)commandCtor.Invoke(paramsToInject.ToArray());

        return command.Execute();
    }
}