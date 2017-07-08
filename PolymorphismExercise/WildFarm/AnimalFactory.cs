namespace WildFarm
{
    using Animals;

    public static class AnimalFactory
    {
        public static Animal ProduceAnimal(string type, string name, double weight, string region)
        {
            switch (type)
            {
                case "Tiger":
                    return new Tiger(type, name, weight, region);
                case "Zebra":
                    return new Zebra(type, name, weight, region);
                case "Mouse":
                    return new Mouse(type, name, weight, region);
                default: return null;
            }
        }

        public static Animal ProduceAnimal(string type, string name, double weight, string region, string breed)
        {
            return new Cat(type, name, weight, region, breed);
        }
    }
}
