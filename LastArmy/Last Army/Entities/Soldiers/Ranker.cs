public class Ranker : Soldier
{
    private const double OverallSkillMiltiplier = 1.5;

    public Ranker(string name, int age, double experience, double endurance)
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