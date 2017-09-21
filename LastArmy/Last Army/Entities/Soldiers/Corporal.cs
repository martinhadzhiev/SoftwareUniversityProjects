public class Corporal : Soldier
{
    private const double OverallSkillMiltiplier = 2.5;

    public Corporal(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance, OverallSkillMiltiplier)
    {
    }

    public override void Regenerate()
    {
        this.Endurance += 10 + this.Age;

        if (this.Endurance > 100)
        {
            this.Endurance = 100;
        }
    }
}