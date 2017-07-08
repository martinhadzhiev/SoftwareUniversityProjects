namespace _05.MordorsCrueltyPlan
{
    using System;
    using System.Collections.Generic;
    using Foods;
    using Factories;

    class Startup
    {
        static void Main()
        {
            var foodTypes = Console.ReadLine()
                .Split(new[] { '\t', '\n', ' '}, StringSplitOptions.RemoveEmptyEntries);

            var foods = new List<Food>();
            var moodFactor = 0;

            foreach (var foodType in foodTypes)
            {
                foods.Add(FoodFactory.MakeFood(foodType));
            }

            foreach (var food in foods)
            {
                moodFactor += food.GetHappinessPoints();
            }

            Console.WriteLine(moodFactor);
            Console.WriteLine(MoodFactory.GetMood(moodFactor));
        }
    }
}
