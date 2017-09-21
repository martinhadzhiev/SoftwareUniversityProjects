using System.Collections.Generic;
using System.Linq;

public class WareHouse : IWareHouse
{
    private readonly List<IAmmunition> ammunitions;

    public WareHouse()
    {
        this.ammunitions = new List<IAmmunition>();
    }

    public void EquipArmy(IArmy army)
    {
        foreach (ISoldier soldier in army.Soldiers)
        {
            if (soldier.GetType().Name == "Ranker")
            {
                try
                {
                    List<IAmmunition> weaponsToAdd = new List<IAmmunition>();

                    weaponsToAdd.Add(this.ammunitions.First(w => w.Name =="Gun"));
                    weaponsToAdd.Add(this.ammunitions.First(w => w.Name == "AutomaticMachine"));
                    weaponsToAdd.Add(this.ammunitions.First(w => w.Name =="Helmet"));

                    weaponsToAdd.ForEach(w => soldier.Weapons.Add(w.Name,w));
                }
                catch
                {
                }
            }
            else if (soldier.GetType().Name == "Corporal")
            {
                try
                {
                    List<IAmmunition> weaponsToAdd = new List<IAmmunition>();

                    weaponsToAdd.Add(this.ammunitions.First(w => w.Name == "Gun"));
                    weaponsToAdd.Add(this.ammunitions.First(w => w.Name == "AutomaticMachine"));
                    weaponsToAdd.Add(this.ammunitions.First(w => w.Name == "Helmet"));
                    weaponsToAdd.Add(this.ammunitions.First(w => w.Name == "MachineGun"));
                    weaponsToAdd.Add(this.ammunitions.First(w => w.Name == "Knife"));

                    weaponsToAdd.ForEach(w => soldier.Weapons.Add(w.Name, w));
                }
                catch
                {
                }
            }
            else
            {
                try
                {
                    List<IAmmunition> weaponsToAdd = new List<IAmmunition>();

                    weaponsToAdd.Add(this.ammunitions.First(w => w.Name == "Gun"));
                    weaponsToAdd.Add(this.ammunitions.First(w => w.Name == "AutomaticMachine"));
                    weaponsToAdd.Add(this.ammunitions.First(w => w.Name == "Helmet"));
                    weaponsToAdd.Add(this.ammunitions.First(w => w.Name == "Knife"));
                    weaponsToAdd.Add(this.ammunitions.First(w => w.Name == "RPG"));
                    weaponsToAdd.Add(this.ammunitions.First(w => w.Name == "NightVision"));
                    weaponsToAdd.Add(this.ammunitions.First(w => w.Name == "MachineGun"));

                    weaponsToAdd.ForEach(w => soldier.Weapons.Add(w.Name, w));
                }
                catch
                {
                }
            }
        }
    }

    public void AddAmmunition(IAmmunition ammunition)
    {
        this.ammunitions.Add(ammunition);
    }
}