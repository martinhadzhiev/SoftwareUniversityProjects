using System.Collections.Generic;

public interface IEngineer : ISpecialisedSoldier
{
    ICollection<KeyValuePair<string, int>> Repairs { get; }
}