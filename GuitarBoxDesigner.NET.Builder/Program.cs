using System;
using System.Collections.Generic;
using System.Linq;

namespace GuitarBoxDesigner.NET.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO add fake service
            var songs = new List<Song>
            {
                new Song("Hello Old Friend", "Eric Clapton"),
                new Song("Your Song", "Elton John")
            };

            var guitarPracticeBuilder = new GuitarPracticeBuilder(songs);
            guitarPracticeBuilder.Tune(true);
            guitarPracticeBuilder.GetPick(true);

            if (songs.Any())
            {
                foreach (var song in songs)
                {
                    guitarPracticeBuilder.PracticeSong(song);
                }
            }

            guitarPracticeBuilder.PutAway();

            var guitarPractice = guitarPracticeBuilder.Practice();

            Console.WriteLine(guitarPractice);

            Console.ReadKey();
        }
    }
}
