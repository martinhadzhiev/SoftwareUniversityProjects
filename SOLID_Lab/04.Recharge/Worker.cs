namespace _04.Recharge
{
    public abstract class Worker
    {
        private string id;
        private int workingHours;

        protected Worker(string id)
        {
            this.id = id;
        }

        protected void Work(int hours)
        {
            this.workingHours += hours;
        }
    }
}