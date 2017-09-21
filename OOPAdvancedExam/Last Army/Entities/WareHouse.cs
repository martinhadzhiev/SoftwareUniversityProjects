using System.Collections.Generic;

public class WareHouse : IWareHouse
{
    private readonly List<IAmmunition> ammunitions;

    public WareHouse()
    {
        this.ammunitions = new List<IAmmunition>();
    }

    public void EquipArmy(IArmy army)
    {
        //TODO:
    }

    public void AddAmmunition(IAmmunition ammunition)
    {
        this.ammunitions.Add(ammunition);
    }
}
