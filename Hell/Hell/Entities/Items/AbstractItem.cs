public abstract class AbstractItem : IItem
{
    private string name;
    private long strengthBonus;
    private long agilityBonus;
    private long intelligenceBonus;
    private long hitPointsBonus;
    private long damageBonus;

    protected AbstractItem(string name, long strengthBonus, long agilityBonus,
        long intelligenceBonus, long hitPointsBonus, long damageBonus)
    {
        this.Name = name;
        this.StrengthBonus = strengthBonus;
        this.AgilityBonus = agilityBonus;
        this.IntelligenceBonus = intelligenceBonus;
        this.HitPointsBonus = hitPointsBonus;
        this.DamageBonus = damageBonus;
    }

    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }

    public long StrengthBonus
    {
        get { return this.strengthBonus; }
        private set { this.strengthBonus = value; }
    }

    public long AgilityBonus
    {
        get { return this.agilityBonus; }
        private set { this.agilityBonus = value; }
    }

    public long IntelligenceBonus
    {
        get { return this.intelligenceBonus; }
        private set { this.intelligenceBonus = value; }
    }

    public long HitPointsBonus
    {
        get { return this.hitPointsBonus; }
        private set { this.hitPointsBonus = value; }
    }

    public long DamageBonus
    {
        get { return this.damageBonus; }
        private set { this.damageBonus = value; }
    }
}