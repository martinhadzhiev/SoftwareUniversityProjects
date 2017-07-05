namespace CatLady
{
    public class Siamese : Cat
    {
        public int earSize;

        public override string ToString()
        {
            return $"{nameof(Siamese)} {this.name} {this.earSize}";
        }
    }
}
