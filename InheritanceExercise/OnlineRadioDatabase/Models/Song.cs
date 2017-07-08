namespace OnlineRadioDatabase.Models
{
    using System.Linq;
    using Exceptions;

    public class Song
    {
        private string artistName;
        private string songName;
        private Length length;

        public Song(string artistName, string songName, Length length)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Length = length;
        }

        private Length Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        private string ArtistName
        {
            get { return this.artistName; }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException("Artist name should be between 3 and 20 symbols.");
                }

                this.artistName = value;
            }
        }

        private string SongName
        {
            get { return this.songName; }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException("Song name should be between 3 and 30 symbols.");
                }

                this.songName = value;
            }
        }

        public long GetSongLength()
        {
            long result = this.Length.GetSongLength();

            return result;
        }

    }
}
