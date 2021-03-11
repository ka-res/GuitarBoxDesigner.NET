using System;

namespace GuitarBoxDesigner.NET.Prototype
{
    public class GigDescription : ICloneable
    {
        public GigType Type { get; set; }
        public int BandSize { get; set; }

        public GigDescription(GigType type, int bandSize)
        {
            this.Type = type;
            this.BandSize = bandSize;
        }

        public object Clone()
        {
            //shallow copy
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"It's {this.Type} Gig played by {this.BandSize} band member(s)";
        }
    }
}
