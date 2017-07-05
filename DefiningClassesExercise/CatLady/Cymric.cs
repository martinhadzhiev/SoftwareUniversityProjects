namespace CatLady
{
    public class Cymric : Cat
    {
        public double furSize;

        public override string ToString()
        {
            return $"{nameof(Cymric)} {this.name} {this.furSize:F2}";
        }
    }
}
