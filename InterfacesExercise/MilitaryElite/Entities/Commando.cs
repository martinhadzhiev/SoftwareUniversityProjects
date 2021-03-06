﻿using System.Collections.Generic;
using System.Text;

public class Commando : SpecialisedSoldier , ICommando
{
    public ICollection<Mission> Missions { get; private set; }

    public Commando(int id, string firstName, string lastName, double salary, string corps) 
        : base(id, firstName, lastName, salary, corps)
    {
        this.Missions = new List<Mission>();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(base.ToString());
        sb.AppendLine("Missions:");

        foreach (var mission in Missions)
        {
            sb.AppendLine(mission.ToString());  
        }

        return sb.ToString().Trim();
    }
}