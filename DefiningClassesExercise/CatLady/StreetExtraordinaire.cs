namespace CatLady
{
    public class StreetExtraordinaire : Cat
    {
        public int decibels;

        public override string ToString()
        {
            return $"{nameof(StreetExtraordinaire)} {this.name} {this.decibels}";
        }
    }
}
