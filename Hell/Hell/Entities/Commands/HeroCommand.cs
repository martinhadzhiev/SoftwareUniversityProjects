using System.Collections.Generic;

public class HeroCommand : Command
{
    public HeroCommand(IList<string> arguments, IManager manager)
         : base(manager, arguments)
    {
    }

    public override string Execute()
    {
        return this.Manager.AddHero(this.Arguments);
    }
}