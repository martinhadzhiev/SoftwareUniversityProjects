﻿namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        public InvalidSongSecondsException(string message)
            : base(message)
        {

        }
    }
}
