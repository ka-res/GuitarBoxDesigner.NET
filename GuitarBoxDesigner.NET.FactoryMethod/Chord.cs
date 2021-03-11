namespace GuitarBoxDesigner.NET.FactoryMethod
{
    public abstract class Chord
    {
        public char Tone { get; set; }
        public ChordMode Mode { get; set; }

        public Chord(char tone, ChordMode mode)
        {
            this.Tone = tone;
            this.Mode = mode;
        }

        public Chord()
        {
        }

        public abstract string ConstructChord();

        public override string ToString()
        {
            return $"{Tone}{Mode}";
        }
    }
}
