using System.Collections.Generic;

public class RecipeCommand : Command
{
    public RecipeCommand(IList<string> arguments, IManager manager)
         : base(manager, arguments)
    {
    }

    public override string Execute()
    {
        return base.Manager.AddItemToHero(this.Arguments);
    }
}