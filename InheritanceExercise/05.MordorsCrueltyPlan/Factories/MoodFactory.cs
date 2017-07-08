namespace _05.MordorsCrueltyPlan.Factories
{
    using Moods;

    public class MoodFactory
    {
        public static Mood GetMood(int moodFactor)
        {
            if (moodFactor < -5)
            {
                return new Angry();
            }
            else if (moodFactor <= 0)
            {
                return new Sad();
            }
            else if(moodFactor <= 15)
            {
                return new Happy();
            }
            else
            {
                return new JavaScript();
            }
        }
    }
}
