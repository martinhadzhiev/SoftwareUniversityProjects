using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    public ICollection<KeyValuePair<string, int>> Repairs { get; private set; }

    public Engineer(int id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary, corps)
    {
        this.Repairs = new List<KeyValuePair<string, int>>();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
        sb.AppendLine($"Corps: {this.Corps}");
        sb.AppendLine("Repairs:");

        foreach (var repair in Repairs)
        {
            sb.AppendLine($"  Part Name: {repair.Key} Hours Worked: {repair.Value}");
        }

        return sb.ToString().Trim();
    }
}