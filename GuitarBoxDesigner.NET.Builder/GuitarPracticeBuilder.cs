using System;
using System.Collections.Generic;
using System.Linq;

namespace GuitarBoxDesigner.NET.Builder
{
    public class GuitarPracticeBuilder : IGuitarPracticeBuilder
    {
        private GuitarPractice guitarPractice;

        public GuitarPracticeBuilder(IEnumerable<Song> songs)
        {
            this.guitarPractice = new GuitarPractice(songs);
        }

        public void GetPick(bool shouldFindPick)
        {
            this.guitarPractice.HasPick = shouldFindPick;
        }

        public GuitarPractice Practice()
        {
            return this.guitarPractice;
        }

        public void PracticeSong(Song song)
        {
            this.guitarPractice.SongsToPractice
                .SingleOrDefault(x => x.Title == song.Title
                    && x.Artist == song.Artist).IsPracticed = true;
        }

        public void PutAway()
        {
            this.guitarPractice.PutAway = true;
        }

        public void Tune(bool shouldBeOk)
        {
            this.guitarPractice.IsTuned = shouldBeOk;
        }
    }
}
