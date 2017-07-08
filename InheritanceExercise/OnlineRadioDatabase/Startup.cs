namespace OnlineRadioDatabase
{
    using System;
    using Models;
    using System.Collections.Generic;
    using System.Linq;
    using Exceptions;

    class Startup
    {
        static void Main()
        {
            var album = new List<Song>();
            var songCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < songCount; i++)
            {
                var tokens = Console.ReadLine().Split(';');

                try
                {
                    if (tokens.Length != 3) throw new InvalidSongException("Invalid song.");

                    var artistName = tokens[0];
                    var songName = tokens[1];
                    var minutes = tokens[2].Split(':').FirstOrDefault();
                    var seconds = tokens[2].Split(':').LastOrDefault();

                    Song song = null;

                    if (!minutes.All(char.IsDigit) || !seconds.All(char.IsDigit))
                    {
                        Length length = new Length(0,0,false);
                        song = new Song(artistName, songName, length);
                    }
                    else
                    {
                        var length = new Length(int.Parse(minutes), int.Parse(seconds));
                        song = new Song(artistName, songName, length);
                    }

                    album.Add(song);

                    Console.WriteLine("Song added.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            Console.WriteLine($"Songs added: {album.Count}");
            if (songCount > 0)
            {
                Console.WriteLine($"Playlist length: {CalculatePlaylistLength(album)}");
            }
            else
            {
                Console.WriteLine($"Playlist length: 0h 0m 0s");
            }
        }

        private static string CalculatePlaylistLength(List<Song> album)
        {
            long totalSec = 0;

            foreach (var song in album)
            {
                totalSec += song.GetSongLength();
            }

            var hours = totalSec / 3600;
            var minutes = (totalSec % 3600) / 60;
            var seconds = (totalSec % 3600) % 60;

            return $"{hours}h {minutes}m {seconds}s";
        }
    }
}
