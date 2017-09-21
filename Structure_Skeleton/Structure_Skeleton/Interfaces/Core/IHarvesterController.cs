using System.Collections.Generic;

public interface IHarvesterController : IController
{
    double OreProduced { get; }

    IReadOnlyCollection<IEntity> Entities { get; }

    string ChangeMode(string mode);
}