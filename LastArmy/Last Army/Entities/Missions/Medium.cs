public class Medium : Mission
{
    private const double MediumMissionEnduranceRequired = 50;
    private const double WearLevelDecreasement = 50;
    private const string MissionName = "Capturing dangerous criminals";

    public Medium(double scoreToComplete)
        : base(MissionName, MediumMissionEnduranceRequired, scoreToComplete, WearLevelDecreasement)
    {
    }
}
