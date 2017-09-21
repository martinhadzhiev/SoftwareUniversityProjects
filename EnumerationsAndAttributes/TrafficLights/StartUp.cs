namespace TrafficLights
{
    using System;
    using System.Collections.Generic;
    using Entities;

    class StartUp
    {
        static void Main()
        {
            IList<TrafficLight> trafficLights = new List<TrafficLight>();

            string[] trafficLightsInfo = Console.ReadLine().Split();
            int stateChangeCount = int.Parse(Console.ReadLine());

            foreach (var trafficInfo in trafficLightsInfo)
            {
                trafficLights.Add(new TrafficLight(trafficInfo));
            }

            for (int stateChange = 0; stateChange < stateChangeCount; stateChange++)
            {
                foreach (var trafficLight in trafficLights)
                {
                    trafficLight.ChangeState();
                }

                Console.WriteLine(string.Join(" ", trafficLights));
            }
        }
    }
}
