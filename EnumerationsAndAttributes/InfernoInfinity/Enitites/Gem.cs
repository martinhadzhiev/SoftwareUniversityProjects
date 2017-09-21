namespace InfernoInfinity.Enitites
{
    using System;

    public class Gem
    {
        private readonly Clarity clarity;

        public Gem(string clarity, string type)
        {
            Enum.TryParse(clarity, out this.clarity);
            SetValues(type);
        }

        public int Strength { get; private set; }

        public int Agility { get; private set; }

        public int Vitality { get; private set; }

        private void SetValues(string type)
        {
            switch (type)
            {
                case "Ruby":
                    this.Strength = 7 + (int)this.clarity;
                    this.Agility = 2 + (int)this.clarity;
                    this.Vitality = 5 + (int)this.clarity;
                    break;

                case "Emerald":
                    this.Strength = 1 + (int)this.clarity;
                    this.Agility = 4 + (int)this.clarity;
                    this.Vitality = 9 + (int)this.clarity;
                    break;

                case "Amethyst":
                    this.Strength = 2 + (int)this.clarity;
                    this.Agility = 8 + (int)this.clarity;
                    this.Vitality = 4 + (int)this.clarity;
                    break;
            }
        }
    }
}
