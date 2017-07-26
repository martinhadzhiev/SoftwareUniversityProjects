namespace Tuple
{
    public class Tuple<I1, I2>
    {
        private I1 item1;
        private I2 item2;

        public Tuple(I1 item1, I2 item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }

        public override string ToString()
        {
            return $"{item1} -> {item2}";
        }
    }
}
