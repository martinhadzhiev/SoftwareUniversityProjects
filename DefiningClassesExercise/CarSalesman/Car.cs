namespace CarSalesman
{
    public class Car
    {
        public string model;
        public Engine engine;
        public int? weight;
        public string color;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
            this.color = "n/a";
        }

        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            this.weight = weight;
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine, weight)
        {
            this.color = color;
        }

        public override string ToString()
        {
            if (this.engine.displacement == null || this.weight == null)
            {
                if (this.engine.displacement == null && this.weight == null)
                {
                    return $"{this.model}:\n" +
                           $"  {this.engine.model}:\n" +
                           $"    Power: {this.engine.power}\n" +
                           $"    Displacement: n/a\n" +
                           $"    Efficiency: {this.engine.efficiency}\n" +
                           $"  Weight: n/a\n" +
                           $"  Color: {this.color}";
                }
                else if (this.weight == null)
                {
                    return $"{this.model}:\n" +
                           $"  {this.engine.model}:\n" +
                           $"    Power: {this.engine.power}\n" +
                           $"    Displacement: {this.engine.displacement}\n" +
                           $"    Efficiency: {this.engine.efficiency}\n" +
                           $"  Weight: n/a\n" +
                           $"  Color: {this.color}";
                }
                else
                {
                    return $"{this.model}:\n" +
                           $"  {this.engine.model}:\n" +
                           $"    Power: {this.engine.power}\n" +
                           $"    Displacement: n/a\n" +
                           $"    Efficiency: {this.engine.efficiency}\n" +
                           $"  Weight: {this.weight}\n" +
                           $"  Color: {this.color}";
                }
            }
            else
            {
                return $"{this.model}:\n" +
                       $"  {this.engine.model}:\n" +
                       $"    Power: {this.engine.power}\n" +
                       $"    Displacement: {this.engine.displacement}\n" +
                       $"    Efficiency: {this.engine.efficiency}\n" +
                       $"  Weight: {this.weight}\n" +
                       $"  Color: {this.color}";
            }

        }
    }
}
