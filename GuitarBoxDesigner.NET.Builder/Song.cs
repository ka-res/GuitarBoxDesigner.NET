namespace GuitarBoxDesigner.NET.Builder
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public bool IsPracticed { get; set; }

        public Song(string title, string artist)
        {
            this.Title = title;
            this.Artist = artist;
        }

        public override string ToString()
        {
            return $"Playing {Title} by {Artist}";
        }
    }
}
