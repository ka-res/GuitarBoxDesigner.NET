namespace GuitarBoxDesigner.NET.Prototype
{
    public class Musician
    {
        public string StageName { get; set; }

        public Musician(string stageName)
        {
            this.StageName = stageName;
        }

        public override string ToString()
        {
            return $"Artist is {StageName}";
        }
    }
}