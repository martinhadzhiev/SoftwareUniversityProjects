﻿public abstract class Mission : IMission
{
    protected Mission(string name, double enduranceRequired,
        double scoreToCoplete, double wearLevelDecreasement)
    {
        this.Name = name;
        this.EnduranceRequired = enduranceRequired;
        this.ScoreToComplete = scoreToCoplete;
        this.WearLevelDecrement = wearLevelDecreasement;
    }

    public string Name { get; private set; }

    public double EnduranceRequired { get; private set; }

    public double ScoreToComplete { get; private set; }

    public double WearLevelDecrement { get; private set; }
}