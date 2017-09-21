namespace Entities.Models
{
    using Interfaces;

    public class SimpleLayout : ILayout
    {
        public SimpleLayout()
        {
            this.Format = "{0} - {1} - {2}";
        }

        public string Format { get; private set; }
    }
}
