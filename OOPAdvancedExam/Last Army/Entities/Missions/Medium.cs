public class Medium : Mission
{
    private const string MissionName = "Capturing dangerous criminals";
    private const double EnduranceReq = 50;
    private const double WearLevelDecreasement = 50;

    public Medium(double scoreToCoplete) 
        : base(MissionName, EnduranceReq, scoreToCoplete, WearLevelDecreasement)
    {
    }
}