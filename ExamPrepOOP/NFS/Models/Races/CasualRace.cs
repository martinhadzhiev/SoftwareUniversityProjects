using System.Linq;
using System.Text;

public class CasualRace : Race
{
    public CasualRace(int length, string route, int prizePool)
        : base(length, route, prizePool)
    {

    }

    public override string ToString()
    {
        if (this.Participants.Count == 0)
        {
            return "Cannot start the race with zero participants.";
        }
        else
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Route} - {this.Length}");

            var winners = this.Participants.OrderByDescending(p => p.Value.GetOverAllPerformance()).Take(3);

            int place = 1;

            foreach (var winner in winners)
            {
                sb.AppendLine($"{place}. {winner.Value.Brand} {winner.Value.Model} {winner.Value.GetOverAllPerformance()}PP - ${this.PrizePool * 0.5}");
                place++;
            }

            return sb.ToString().Trim();
        }
    }
}