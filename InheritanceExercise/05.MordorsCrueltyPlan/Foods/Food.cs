namespace _05.MordorsCrueltyPlan.Foods
{
    public abstract class Food
    {
        private int points;

        public Food(int points)
        {
            this.points = points;
        }

        public int GetHappinessPoints()
        {
            return this.points;
        }
    }
}
