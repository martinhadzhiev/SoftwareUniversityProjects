public interface ICommand
{
    IManager Manager { get; }

    string Execute();
}