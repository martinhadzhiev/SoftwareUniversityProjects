namespace FamilyTree
{
    using System.Collections.Generic;

    public class Person
    {
        public string name;
        public string birthday;
        public List<Person> parents;

        public Person()
        {
            this.parents = new List<Person>();
        }
    }
}
