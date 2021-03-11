using System;

namespace GuitarBoxDesigner.NET.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype");

            var player = new Musician("KaReS");
            var place = new Local("Subway Pub");
            var start = new DateTime(2021, 04, 01, 17, 00, 00);
            var end = new DateTime(2021, 04, 01, 20, 00, 00);

            var firstPerformance = new Performance(place, start, end, player);
            firstPerformance.Description = new GigDescription(GigType.Acoustic, 1);

            var secondPerformance = new Performance(place, start, end, player);
            secondPerformance.Description = new GigDescription(GigType.HardRock, 5);

            Console.WriteLine(firstPerformance);
            Console.WriteLine(secondPerformance);

            var firstPerformanceCopy = (Performance)firstPerformance.Clone();

            Console.WriteLine(firstPerformanceCopy);
            Console.WriteLine();

            if (ReferenceEquals(firstPerformance, firstPerformanceCopy))
            {
                Console.WriteLine("The same acoustic performances");
            }
            else
            {
                Console.WriteLine("Different acoustic performances");
            }

            if (ReferenceEquals(firstPerformance.Description, firstPerformanceCopy.Description))
            {
                Console.WriteLine("The same acoustic performances details");
            }
            else
            {
                Console.WriteLine("Different acoustic performances details");
            }

            // Something else - not working with nesting by design
            var secondPerformanceCopy = FastDeepCloner.DeepCloner.Clone(secondPerformance);

            Console.WriteLine(secondPerformanceCopy);
            Console.WriteLine();

            if (ReferenceEquals(secondPerformance, secondPerformanceCopy))
            {
                Console.WriteLine("The same hard rock performances");
            }
            else
            {
                Console.WriteLine("Different hard rock performances");
            }

            if (ReferenceEquals(secondPerformanceCopy.Description, secondPerformanceCopy.Description))
            {
                Console.WriteLine("The same hard rock performances details");
            }
            else
            {
                Console.WriteLine("Different hard rock performances details");
            }

            Console.ReadKey();
        }
    }
}
