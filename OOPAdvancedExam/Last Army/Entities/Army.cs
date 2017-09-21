using System.Collections.Generic;

public class Army : IArmy
{
    private List<ISoldier> soldiersToAdd;

    public Army()
    {
        this.soldiersToAdd = new List<ISoldier>();
        this.Soldiers = new List<ISoldier>();
    }

    public IReadOnlyList<ISoldier> Soldiers { get; }

    public void AddSoldier(ISoldier soldier)
    {
        throw new System.NotImplementedException();
    }

    public void RegenerateTeam(string soldierType)
    {
        throw new System.NotImplementedException();
    }
}