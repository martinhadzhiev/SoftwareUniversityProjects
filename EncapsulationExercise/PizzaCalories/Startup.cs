namespace PizzaCalories
{
    using System;

    class Startup
    {
        static void Main()
        {
            try
            {
                var line = Console.ReadLine();
                while (line != "END")
                {
                    var lineArgs = line.Split();

                    if (lineArgs[0] == "Pizza")
                    {

                        if (int.Parse(lineArgs[2]) < 0 || int.Parse(lineArgs[2]) > 10)
                        {
                            throw new ArgumentException("Number of toppings should be in range [0..10].");
                        }

                        var doughInfo = Console.ReadLine().Split();
                        var dough = new Dough(doughInfo[1], doughInfo[2], int.Parse(doughInfo[3]));
                        var pizza = new Pizza(lineArgs[1], dough);

                        for (int i = 0; i < int.Parse(lineArgs[2]); i++)
                        {
                            var toppingInfo = Console.ReadLine().Split();
                            var topping = new Topping(toppingInfo[1], int.Parse(toppingInfo[2]));
                            pizza.AddTopping(topping);
                        }

                        Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():F2} Calories.");
                        return;
                    }
                    else
                    {
                        switch (lineArgs[0].ToLower())
                        {
                            case "dough":
                                var dough = new Dough(lineArgs[1], lineArgs[2], int.Parse(lineArgs[3]));
                                Console.WriteLine($"{dough.GetCalories():F2}");
                                break;
                            case "topping":
                                var topping = new Topping(lineArgs[1], int.Parse(lineArgs[2]));
                                Console.WriteLine($"{topping.GetCalories():F2}");
                                break;
                        }
                    }

                    line = Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
