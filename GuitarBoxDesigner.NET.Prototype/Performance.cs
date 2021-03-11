using System;

namespace GuitarBoxDesigner.NET.Prototype
{
    public class Performance : ICloneable
    {
        public Local Place { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Musician Player { get; set; }
        public GigDescription Description { get; set; }
        public TimeSpan Duration { get; set; }

        public Performance(Local place, DateTime start, DateTime end, Musician player)
        {
            this.Place = place;
            this.StartTime = start;
            this.EndTime = end;
            this.Player = player;
            this.Duration = end - start;
        }

        public object Clone()
        {
            var invoiceCopy = new Performance(this.Place, this.StartTime, this.EndTime, this.Player);
            invoiceCopy.Description = (GigDescription)this.Description.Clone();

            return invoiceCopy;
        }

        public override string ToString()
        {
            return $"Announcing Gig! Start at {this.StartTime} (duration: {this.Duration}).{Environment.NewLine}{Player}.{Environment.NewLine}{Place}{Environment.NewLine}{Description}";
        }
    }
}
