using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private Dictionary<int, Car> participants;

    public Race(int length, string route, int prizePool)
    {
        this.length = length;
        this.route = route;
        this.prizePool = prizePool;
        this.participants = new Dictionary<int, Car>();
    }

    protected int Length
    {
        get { return this.length; }
    }

    protected string Route
    {
        get { return this.route; }
    }

    protected int PrizePool
    {
        get { return this.prizePool; }
    }

    protected Dictionary<int, Car> Participants
    {
        get { return this.participants; }
    }

    public void AddParticipant(int id, Car participant)
    {
        this.participants.Add(id, participant);
    }

    public bool ContainsParticipant(int id)
    {
        if (this.participants.ContainsKey(id))
        {
            return true;
        }

        return false;
    }
}