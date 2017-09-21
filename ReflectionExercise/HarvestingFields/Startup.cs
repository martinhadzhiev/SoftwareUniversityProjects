namespace HarvestingFields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class StartUp
    {
        static void Main()
        {
            Type harvestingFields = typeof(HarvestingFields);
            FieldInfo[] fields = harvestingFields.GetFields(BindingFlags.Static | BindingFlags.Instance |
                BindingFlags.Public | BindingFlags.NonPublic);

            string command = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            while (command != "HARVEST")
            {
                List<FieldInfo> fiedsToPrint = new List<FieldInfo>();

                switch (command)
                {
                    case "private":
                        fiedsToPrint = fields.Where(f => f.IsPrivate).ToList();
                        break;
                    case "protected":
                        fiedsToPrint = fields.Where(f => f.IsFamily).ToList();
                        break;
                    case "public":
                        fiedsToPrint = fields.Where(f => f.IsPublic).ToList();
                        break;
                    case "all":
                        fiedsToPrint = fields.ToList();
                        break;
                }

                fiedsToPrint
                    .ForEach(f => result
                    .AppendLine(
                        $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}"));

                command = Console.ReadLine();
            }

            result.Replace("family", "protected");

            Console.WriteLine(result.ToString().Trim());
        }
    }
}
