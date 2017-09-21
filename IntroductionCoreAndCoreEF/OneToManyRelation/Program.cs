namespace OneToManyRelation
{
    class Program
    {
        static void Main()
        {
            using (Database db = new Database())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                Department d = new Department()
                {
                    Name = "Programming"
                };

                Employee manager = new Employee()
                {
                    Name = "ManagerEmp",
                    Department = d,
                };

                Employee e = new Employee()
                {
                    Name = "Ivan",
                    Department = d,
                    Manager = manager
                };

                db.Add(e);
                db.SaveChanges();
            }
        }
    }
}
