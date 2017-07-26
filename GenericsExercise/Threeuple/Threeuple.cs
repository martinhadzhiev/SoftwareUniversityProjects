namespace Threeuple
{
    public class Threeuple<I1, I2, I3>
    {
        private I1 item1;
        private I2 item2;
        private I3 item3;

        public Threeuple(I1 item1, I2 item2, I3 item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public override string ToString()
        {
            return $"{this.item1} -> {this.item2} -> {this.item3}";
        }
    }
}
