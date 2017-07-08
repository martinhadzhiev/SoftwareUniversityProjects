namespace _02.BookShop
{
    using System;
    using System.Linq;
    using System.Text;

    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title , string author , decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        protected decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");    
                }

                this.price = value;
            }
        }

        private string Author
        {
            get { return this.author; }
            set
            {
                if (value.Trim().Split().Length == 2 && char.IsDigit(value.Split().Last().Trim()[0]))
                {
                    throw new ArgumentException("Author not valid!");
                }

                this.author = value;
            }
        }
        
        private string Title
        {
            get { return this.title; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }

        public override string ToString()
        {
             var result = new StringBuilder();
             result.Append("Type: ").AppendLine(this.GetType().Name)
                 .Append("Title: ").AppendLine(this.Title)
                 .Append("Author: ").AppendLine(this.Author)
                 .Append("Price: ").Append($"{this.Price:F1}")
                 .AppendLine();

            return result.ToString();
        }
    }
}
