public class Hard : Mission
{
    private const double HardMissionEnduranceRequired = 80;
    private const double WearLevelDecreasement = 70;
    private const string MissionName = "Disposal of terrorists";

    public Hard(double scoreToComplete)
        : base(MissionName, HardMissionEnduranceRequired, scoreToComplete, WearLevelDecreasement)
    {
    }
}
