namespace CardSuit.Attributes
{
    using System;

    public class TypeAttribute : Attribute
    {
        public TypeAttribute(string type, string category, string description)
        {
            this.Type = type;
            this.Category = category;
            this.Description = description;
        }

        private string Type { get; set; }

        private string Category { get; set; }

        private string Description { get; set; }

        public override string ToString()
        {
            return $"Type = {this.Type}, Description = {this.Description}";
        }
    }
}
