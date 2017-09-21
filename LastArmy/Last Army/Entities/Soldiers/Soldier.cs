using System.Collections.Generic;

public abstract class Soldier : ISoldier
{
    protected Soldier(string name, int age, double experience, double endurance, double skillMultiplier)
    {
        this.Name = name;
        this.Age = age;
        this.Experience = experience;
        this.Endurance = endurance;
        this.SetOverallSkill(skillMultiplier);
        this.Weapons = new Dictionary<string, IAmmunition>();
    }

    public string Name { get; private set; }

    public int Age { get; private set; }

    public double Experience { get; private set; }

    public double Endurance { get; protected set; }

    public double OverallSkill { get; private set; }

    public IDictionary<string, IAmmunition> Weapons { get; }

    public abstract void Regenerate();

    public bool ReadyForMission(IMission mission)
    {
        throw new System.NotImplementedException();
    }

    public void CompleteMission(IMission mission)
    {
        throw new System.NotImplementedException();
    }

    private void SetOverallSkill(double skillMultiplier)
    {
        this.OverallSkill = (this.Age + this.Experience) * skillMultiplier;
    }

    //private double endurance;

    //public IDictionary<string, IAmmunition> Weapons { get; }

    //protected abstract IReadOnlyList<string> WeaponsAllowed { get; }

    //public bool ReadyForMission(IMission mission)
    //{
    //    if (this.Endurance < mission.EnduranceRequired)
    //    {
    //        return false;
    //    }

    //    bool hasAllEquipment = this.Weapons.Values.Count(weapon => weapon == null) == 0;

    //    if (!hasAllEquipment)
    //    {
    //        return false;
    //    }

    //    return this.Weapons.Values.Count(weapon => weapon.WearLevel <= 0) == 0;
    //}

    //private void AmmunitionRevision(double missionWearLevelDecrement)
    //{
    //    IEnumerable<string> keys = this.Weapons.Keys.ToList();
    //    foreach (string weaponName in keys)
    //    {
    //        this.Weapons[weaponName].DecreaseWearLevel(missionWearLevelDecrement);

    //        if (this.Weapons[weaponName].WearLevel <= 0)
    //        {
    //            this.Weapons[weaponName] = null;
    //        }
    //    }
    //}

    //public override string ToString() => string.Format(OutputMessages.SoldierToString, this.Name, this.OverallSkill);
}