using System;

namespace GuitarBoxDesigner.NET.Singleton
{
    public class GuitarTuning
    {
        private static object syncLock = new object();
        private static GuitarTuning instance;

        public GuitarTuning()
        {
            this.Strings = new char[6];
            this.InstationTimeStamp = DateTime.Now;
        }

        public string Name { get; set; }
        public char[] Strings { get; set; }
        public DateTime InstationTimeStamp { get; set; }

        public string GetTuning(string name, params char[] notes)
        {
            this.Name = name;

            if (notes.Length == 6)
            {
                for (int i = 0; i < notes.Length; i++)
                {
                    this.Strings[i] = notes[i];
                }
            }

            return this.ToString();
        }

        public override string ToString()
        {
            var result = string.Empty;

            result += $"Tuning: {this.Name}{Environment.NewLine}";

            for (int i = 0; i < this.Strings.Length; i++)
            {
                result += $"\tString {i + 1}: {this.Strings[i]}{Environment.NewLine}";
            }

            result += $"Creation timestamp: {this.InstationTimeStamp}{Environment.NewLine}";

            return result;
        }
    }
}
