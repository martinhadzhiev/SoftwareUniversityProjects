public class Hard : Mission
{
    private const string MissionName = "Disposal of terrorists";
    private const double EnduranceReq = 80;
    private const double WearLevelDecreasement = 70;

    public Hard(double scoreToCoplete) 
        : base(MissionName, EnduranceReq, scoreToCoplete, WearLevelDecreasement)
    {
    }
}