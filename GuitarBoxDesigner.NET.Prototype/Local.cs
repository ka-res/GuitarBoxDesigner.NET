namespace GuitarBoxDesigner.NET.Prototype
{
    public class Local
    {
        public string Name { get; set; }

        public Local(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return $"Place is {Name}.";
        }
    }
}