namespace GuitarBoxDesigner.NET.FactoryMethod
{
    public class MinorChord : Chord
    {
        public MinorChord(char tone)
        {
            this.Tone = char.ToLower(tone);
            this.Mode = ChordMode.Min;
        }

        public override string ConstructChord()
        {
            return this.ToString();
        }
    }
}
