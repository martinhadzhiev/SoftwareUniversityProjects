namespace Entities.Models
{
    using System;
    using Interfaces;

    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; }

        public void Append()
        {
            throw new NotImplementedException();
        }
    }
}
