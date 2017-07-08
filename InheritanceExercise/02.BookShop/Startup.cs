namespace _02.BookShop
{
    using System;

    class Startup
    {
        static void Main()
        {
            try
            {
                string author = Console.ReadLine();
                string title = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine());

                Book book = new Book(title, author, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(title, author, price);

                Console.WriteLine(book.ToString());
                Console.WriteLine(goldenEditionBook.ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
