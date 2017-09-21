namespace _03.Detail_Printer
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Manager : Employee
    {
        public Manager(string name, ICollection<string> documents)
            : base(name)
        {
            this.Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; private set; }

        public override string PrintDetails()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(base.PrintDetails());
            result.Append(string.Join(Environment.NewLine, this.Documents));

            return result.ToString();
        }
    }
}
