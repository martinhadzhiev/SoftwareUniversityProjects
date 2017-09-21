namespace ManyToMany
{
    using Models;

    class Program
    {
        static void Main(string[] args)
        {
            using (Database db = new Database())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
            }
        }
    }
}
