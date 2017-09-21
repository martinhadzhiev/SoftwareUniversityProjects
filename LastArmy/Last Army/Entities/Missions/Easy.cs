public class Easy : Mission
{
    private const double EasyMissionEnduranceRequired = 20;
    private const double WearLevelDecreasement = 30;
    private const string MissionName = "Suppression of civil rebellion";

    public Easy(double scoreToComplete)
        : base(MissionName, EasyMissionEnduranceRequired, scoreToComplete, WearLevelDecreasement)
    {
    }
}
