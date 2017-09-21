namespace TrafficLights.Entities
{
    using System;

    public class TrafficLight
    {
        private Light light;

        public TrafficLight(string light)
        {
            Enum.TryParse(light, out this.light);
        }

        public void ChangeState()
        {
            int states = typeof(Light).GetEnumNames().Length;

            if ((int)++this.light >= states)
            {
                this.light = 0;
            }
        }

        public override string ToString()
        {
            return this.light.ToString();
        }
    }
}
