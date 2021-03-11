namespace GuitarBoxDesigner.NET.FactoryMethod
{
    public interface IChordFactory
    {
        Chord Create(char tone, ChordMode mode);
    }
}
