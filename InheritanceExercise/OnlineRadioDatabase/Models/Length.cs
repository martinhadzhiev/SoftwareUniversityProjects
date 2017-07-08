namespace OnlineRadioDatabase.Models
{
    using System.Linq;
    using Exceptions;

    public class Length
    {
        private int minutes;
        private int seconds;
        private bool isValid;

        public Length(int minutes, int seconds)
        {
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public Length(int minutes, int seconds, bool isValid)
            : base()
        {
            this.IsValid = isValid;
        }

        private bool IsValid
        {
            get { return this.isValid; }
            set
            {
                if (!value)
                {
                    throw new InvalidSongLengthException("Invalid song length.");
                }
                this.isValid = value;
            }
        }

        private int Minutes
        {
            get { return this.minutes; }
            set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException("Song minutes should be between 0 and 14.");
                }

                this.minutes = value;
            }
        }

        private int Seconds
        {
            get { return this.seconds; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException("Song seconds should be between 0 and 59.");
                }

                this.seconds = value;
            }
        }

        public long GetSongLength()
        {
            var result = 0;

            result += this.seconds;
            result += this.minutes * 60;

            return result;
        }
    }
}
