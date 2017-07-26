using System;
using System.Text;

public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    private string corps;

    protected SpecialisedSoldier(int id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }

    public string Corps
    {
        get { return this.corps; }
        private set
        {
            if (value != "Airforces" && value != "Marines")
            {
                throw new ArgumentException();
            }

            this.corps = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(base.ToString());
        sb.AppendLine($"Corps: {this.Corps}");

        return sb.ToString().Trim();
    }
}