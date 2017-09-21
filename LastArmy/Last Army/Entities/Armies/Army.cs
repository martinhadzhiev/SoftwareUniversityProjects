using System;
using System.Collections.Generic;
using System.Linq;

public class Army : IArmy
{
    private List<ISoldier> soldiersToAdd;

    public Army()
    {
        this.soldiersToAdd = new List<ISoldier>();
        this.Soldiers = new List<ISoldier>();
    }

    public IReadOnlyList<ISoldier> Soldiers { get; private set; }

    public void AddSoldier(ISoldier soldier)
    {
        this.soldiersToAdd.Add(soldier);
        this.Soldiers = soldiersToAdd;
    }

    public void RegenerateTeam(string soldierType)
    {
        this.Soldiers.Where(s => s.GetType().Name == soldierType).ToList().ForEach(s => s.Regenerate());
    }
}