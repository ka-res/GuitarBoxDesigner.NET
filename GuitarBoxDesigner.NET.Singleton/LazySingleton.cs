using System;

namespace GuitarBoxDesigner.NET.Singleton
{
    public class LazySingleton<T>
        where T : new()
    {
        private static readonly Lazy<T> lazy = new Lazy<T>(() => new T());

        public static T Instance => lazy.Value;
    }
}
