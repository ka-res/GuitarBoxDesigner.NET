namespace GuitarBoxDesigner.NET.Singleton
{
    public class Singleton<T>
        where T : new()
    {
        private static object syncLock = new object();
        private static T instance;

        protected Singleton()
        {
        }

        public static T Instance
        {
            get
            {
                lock (syncLock)
                {
                    if (instance == null)
                    {
                        instance = new T();
                    }
                }

                return instance;
            }
        }
    }
}
