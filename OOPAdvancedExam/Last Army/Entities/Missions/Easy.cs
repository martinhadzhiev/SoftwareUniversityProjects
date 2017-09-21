public class Easy : Mission
{
    private const string MissionName = "Suppression of civil rebellion";
    private const double EnduranceReq = 20;
    private const double WearLevelDecreasement = 30;

    public Easy(double scoreToCoplete) 
        : base(MissionName, EnduranceReq, scoreToCoplete, WearLevelDecreasement)
    {
    }
}