using System.Collections.Generic;
using System.Linq;

public abstract class Soldier : ISoldier
{
    protected Soldier(string name, int age, double experience,
        double endurance, double skillMultiplier)
    {
        this.Name = name;
        this.Age = age;
        this.Experience = experience;
        this.Endurance = endurance;
        this.OverallSkill = (this.Age + this.Experience) * skillMultiplier;
        this.Weapons = new Dictionary<string, IAmmunition>();
    }

    public string Name { get; private set; }

    public int Age { get; private set; }

    public double Experience { get; private set; }

    public double Endurance { get; private set; }

    public double OverallSkill { get; private set; }

    public IDictionary<string, IAmmunition> Weapons { get; private set; }

    protected abstract IReadOnlyList<string> WeaponsAllowed { get; }

    public virtual void Regenerate()
    {
        this.Endurance += 10 + this.Age;
    }

    public bool ReadyForMission(IMission mission)
    {
        if (this.Endurance < mission.EnduranceRequired)
        {
            return false;
        }

        bool hasAllEquipment = this.Weapons.Values.Count(weapon => weapon == null) == 0;

        if (!hasAllEquipment)
        {
            return false;
        }

        return this.Weapons.Values.Count(weapon => weapon.WearLevel <= 0) == 0;
    }

    public void CompleteMission(IMission mission)
    {
        throw new System.NotImplementedException();
    }

    private void AmmunitionRevision(IMission mission)
    {
        IEnumerable<string> keys = this.Weapons.Keys.ToList();
        foreach (string weaponName in keys)
        {
            this.Weapons[weaponName].DecreaseWearLevel(mission.WearLevelDecrement);

            if (this.Weapons[weaponName].WearLevel <= 0)
            {
                this.Weapons[weaponName] = null;
            }
        }
    }
}