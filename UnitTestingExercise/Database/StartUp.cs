namespace Database
{
    using System;
    using Entities;

    class StartUp
    {
        static void Main()
        {
            Database database = new Database(2);

            database.Remove();
        }
    }
}
