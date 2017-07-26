using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    public IList<ISoldier> Privates { get; private set; }

    public LeutenantGeneral(int id, string firstName, string lastName, double salary)
        : base(id, firstName, lastName, salary)
    {
        this.Privates = new List<ISoldier>();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
        sb.AppendLine("Privates:");

        foreach (var privateSoldier in Privates)
        {
            sb.AppendLine("  " + privateSoldier.ToString());
        }

        return sb.ToString().Trim();
    }
}