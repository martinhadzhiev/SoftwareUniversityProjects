namespace CatLady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            var cats = new List<Cat>();

            var cat = Console.ReadLine();

            while (cat != "End")
            {
                var catTokens = cat.Trim().Split();
                
                switch (catTokens[0])
                {
                    case "StreetExtraordinaire":
                        var streetCat = new StreetExtraordinaire();
                        streetCat.name = catTokens[1];
                        streetCat.decibels = int.Parse(catTokens[2]);

                        cats.Add(streetCat);
                        break;

                    case "Siamese":
                        var siameseCat = new Siamese();
                        siameseCat.name = catTokens[1];
                        siameseCat.earSize = int.Parse(catTokens[2]);

                        cats.Add(siameseCat);
                        break;

                    case "Cymric":
                        var cymricCat = new Cymric();
                        cymricCat.name = catTokens[1];
                        cymricCat.furSize = double.Parse(catTokens[2]);

                        cats.Add(cymricCat);
                        break;
                }

                cat = Console.ReadLine();
            }

            var catName = Console.ReadLine();

            Console.WriteLine(cats.FirstOrDefault(c => c.name == catName).ToString());
        }
    }
}
