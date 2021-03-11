namespace GuitarBoxDesigner.NET.FactoryMethod
{
    public class MajorChord : Chord
    {
        public MajorChord(char tone)
        {
            this.Tone = char.ToUpper(tone);
            this.Mode = ChordMode.Maj;
        }

        public override string ConstructChord()
        {
            return this.ToString();
        }
    }
}
