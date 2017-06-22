namespace GroupByGroup
{
    public class Person
    {
        public Person(string name, int group)
        {
            this.Group = group;
            this.Name = name;
        }
        public string Name { get; set; }

        public int Group { get; set; }
    }
}
