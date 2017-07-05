namespace PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            var trainers = new List<Trainer>();
            var line = Console.ReadLine();

            while (line != "Tournament")
            {
                var tokens = line.Trim().Split();
                var trainer = new Trainer(tokens[0]);
                var pokemon = new Pokemon(tokens[1], tokens[2], double.Parse(tokens[3]));
                trainer.pokemons.Add(pokemon);

                if (trainers.All(t => t.name != tokens[0]))
                {
                    trainers.Add(trainer);
                }
                else
                {
                    trainers.FirstOrDefault(t => t.name == tokens[0]).pokemons.Add(pokemon);
                }

                line = Console.ReadLine();
            }

            line = Console.ReadLine();

            while (line != "End")
            {

                foreach (var trainer in trainers.Where(t => t.pokemons.All(p => p.element != line)))
                {
                    var pokemonsToRemove = new List<Pokemon>();

                    foreach (var pokemon in trainer.pokemons)
                    {
                        if (pokemon.health - 10 <= 0)
                        {
                            pokemonsToRemove.Add(pokemon);
                        }
                        else
                        {
                            pokemon.health -= 10;
                        }
                    }

                    foreach (var p in pokemonsToRemove)
                    {
                        trainer.pokemons.Remove(p);
                    }
                }

                trainers.Where(t => t.pokemons.Any(p => p.element == line)).ToList().ForEach(t => t.numberOfBadges++);

                line = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.numberOfBadges))
            {
                Console.WriteLine($"{trainer.name} {trainer.numberOfBadges} {trainer.pokemons.Count}");
            }
        }
    }
}
