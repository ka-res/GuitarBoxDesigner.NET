using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuitarBoxDesigner.NET.Builder
{
    public class GuitarPractice
    {
        public bool HasPick { get; set; }
        public bool IsTuned { get; set; }
        public bool PutAway { get; set; }
        public IEnumerable<Song> SongsToPractice { get; set; }

        public GuitarPractice(IEnumerable<Song> songs)
        {
            this.SongsToPractice = songs;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Playing...");
            stringBuilder.AppendLine(IsTuned ? "Tuned" : "Not tuned");
            stringBuilder.AppendLine(HasPick ? "With pick" : "As fingerstyle");

            foreach (var song in SongsToPractice.Where(x => x.IsPracticed))
            {
                stringBuilder.AppendLine(song.ToString());
            }

            stringBuilder.AppendLine(PutAway ? "Done" : "Could not finish");

            return stringBuilder.ToString();
        }
    }
}
