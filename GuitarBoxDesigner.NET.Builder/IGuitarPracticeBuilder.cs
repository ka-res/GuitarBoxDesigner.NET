namespace GuitarBoxDesigner.NET.Builder
{
    public interface IGuitarPracticeBuilder
    {
        void Tune(bool shouldBeOk);
        void GetPick(bool shouldFindPick);
        void PracticeSong(Song song);
        void PutAway();
        GuitarPractice Practice();
    }
}
