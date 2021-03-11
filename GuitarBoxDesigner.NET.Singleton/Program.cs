using System;
using System.Threading;

namespace GuitarBoxDesigner.NET.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSingleton();
            Thread.Sleep(2000);
            TestLazySingleton();

            Console.ReadKey();
        }

        private static void TestSingleton()
        {
            Console.WriteLine("Singleton");

            var firstGuitarTuning = LazySingleton<GuitarTuning>.Instance;
            var secondGuitarTuning = LazySingleton<GuitarTuning>.Instance;

            if (ReferenceEquals(firstGuitarTuning, secondGuitarTuning))
            {
                Console.WriteLine(firstGuitarTuning.GetTuning("Standard", 'e', 'a', 'd', 'g', 'b', 'e'));
                Thread.Sleep(1000);
                Console.WriteLine(secondGuitarTuning.GetTuning("Drop d", 'd', 'a', 'd', 'g', 'b', 'd'));
                Console.WriteLine("This is Singleton");
            }
            else
            {
                Console.WriteLine(firstGuitarTuning.GetTuning("Standard", 'e', 'a', 'd', 'g', 'b', 'e'));
                Thread.Sleep(1000);
                Console.WriteLine(secondGuitarTuning.GetTuning("Drop d", 'd', 'a', 'd', 'g', 'b', 'd'));
                Console.WriteLine("The Singleton instances are different");
            }
        }

        private static void TestLazySingleton()
        {
            Console.WriteLine("LazySingleton");

            var firstGuitarTuning = Singleton<GuitarTuning>.Instance;
            var secondGuitarTuning = Singleton<GuitarTuning>.Instance;

            if (ReferenceEquals(firstGuitarTuning, secondGuitarTuning))
            {
                Console.WriteLine(firstGuitarTuning.GetTuning("Standard", 'e', 'a', 'd', 'g', 'b', 'e'));
                Thread.Sleep(1000);
                Console.WriteLine(secondGuitarTuning.GetTuning("Drop d", 'd', 'a', 'd', 'g', 'b', 'd'));
                Console.WriteLine("This is LazySingleton");
            }
            else
            {
                Console.WriteLine(firstGuitarTuning.GetTuning("Standard", 'e', 'a', 'd', 'g', 'b', 'e'));
                Thread.Sleep(1000);
                Console.WriteLine(secondGuitarTuning.GetTuning("Drop d", 'd', 'a', 'd', 'g', 'b', 'd'));
                Console.WriteLine("The LazySingleton instances are different");
            }
        }
    }
}
