using System;

namespace GuitarBoxDesigner.NET.FactoryMethod
{
    public class GuitarChordFactory : IChordFactory
    {
        public Chord Create(char tone, ChordMode mode)
        {
            switch (mode)
            {
                case ChordMode.Min:
                    return new MinorChord(tone);
                case ChordMode.Maj:
                    return new MajorChord(tone);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
