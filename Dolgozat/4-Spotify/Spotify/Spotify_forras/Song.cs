namespace Spotify
{
    internal class Song
    {
        public Song(string title, string artist, int duration, int year, int rating)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Year = year;
            Rating = rating;
        }

        public string Title { get; }
        public string Artist { get; }
        public int Duration { get; }
        public int Year { get; }
        public int Rating { get; }

        public override string ToString()
        {
            return $"{Title} - {Artist} ({Year}), {Duration} mp, {Rating} pont.";
        }
    }
}
