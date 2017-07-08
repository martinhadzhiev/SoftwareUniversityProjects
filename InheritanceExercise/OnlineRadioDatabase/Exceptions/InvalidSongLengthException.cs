namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidSongLengthException : InvalidSongException
    {
        public InvalidSongLengthException(string message)
            : base(message)
        {

        }
    }
}
