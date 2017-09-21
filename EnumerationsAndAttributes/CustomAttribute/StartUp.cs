namespace CustomAttribute
{
    using System;
    using System.Linq;
    using System.Text;
    using Attributes;

    [Custom("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.",
        new[] { "Pesho", "Svetlio" })]
    public class StartUp
    {
        static void Main()
        {
            var customAttribute = typeof(StartUp).GetCustomAttributes(false).FirstOrDefault();

            if (customAttribute.GetType() == typeof(CustomAttribute))
            {
                CustomAttribute attribute = (CustomAttribute)customAttribute;

                StringBuilder result = new StringBuilder();
                result.AppendLine($"Author: {attribute.Author}");
                result.AppendLine($"Revision: {attribute.Revision}");
                result.AppendLine($"Class description: {attribute.Description}");
                result.AppendLine($"Reviewers: {string.Join(", ", attribute.Reviewers)}");

                Console.WriteLine(result.ToString().Trim());
            }
        }
    }
}

