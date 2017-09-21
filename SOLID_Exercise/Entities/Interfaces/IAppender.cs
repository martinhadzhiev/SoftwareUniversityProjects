namespace Entities.Interfaces
{
    public interface IAppender
    {
        ILayout Layout { get; }

        void Append();
    }
}
