using System;

namespace GuitarBoxDesigner.NET.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FactoryMethod");

            IChordFactory chordFactory = new GuitarChordFactory();
            var minorChord = chordFactory.Create('a', ChordMode.Min);
            var majorChord = chordFactory.Create('C', ChordMode.Maj);

            Console.WriteLine($"Minor chord: {minorChord}");
            Console.WriteLine($"Major chord: {majorChord}");

            Console.ReadKey();
        }
    }
}
