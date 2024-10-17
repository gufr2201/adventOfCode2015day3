using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CiP
{

    public class Routes
    {
        string directions = ReadFile.ReadFileFunction();
        public static int RouteCalculator(string directions)
        {
            HashSet<(int, int)> visitedHouses = new HashSet<(int, int)>();
            int x = 0;
            int y = 0;
            visitedHouses.Add((x, y));

            foreach (char direction in directions)
            {
                switch (direction)
                {
                    case '^': y++; break;
                    case 'v': y--; break;
                    case '>': x++; break;
                    case '<': x--; break;

                }
                visitedHouses.Add((x, y));
            }
            Console.WriteLine($"amount of houses that got at least one christmas present: {visitedHouses.Count}");
            return visitedHouses.Count;
        }
    }
}

//    public interface IDeliveryEntity
//    {
//        void Move(char direction);
//        (int X, int Y) Position { get; }
//    }
//    public class Santa : IDeliveryEntity
//    {
//        public int X { get; private set; }
//        public int Y { get; private set; }
//        public (int X, int Y) Position => (X, Y);

//        public void Move(char direction)
//        {
//            switch (direction)
//            {
//                case '^': Y++; break;
//                case 'v': Y--; break;
//                case '>': X++; break;
//                case '<': Y--; break;
//            }
//        }
//        public class RoboSanta : IDeliveryEntity
//        {
//            public int X { get; private set; }
//            public int Y { get; private set; }
//            public (int X, int Y) Position => (X, Y);

//            public void Move(char direction)
//            {
//                switch (direction)
//                {
//                    case '^': Y--; break;
//                    case 'v': Y++; break;
//                    case '>': X--; break;
//                    case '<': Y++; break;
//                }
//            }
//            public class RouteCalculator
//            {
//                public HashSet<(int, int)> CalculateVisitedHouses(string directions, params IDeliveryEntity[] entities)
//                {
//                    var visitedHouses = new HashSet<(int, int)>();
//                    visitedHouses.Add((0, 0)); //starting house

//                    int entityIndex = 0;
//                    foreach (char direction in directions)
//                    {
//                        entities[entityIndex].Move(direction);
//                        visitedHouses.Add(entities[entityIndex].Position);
//                        entityIndex = (entityIndex + 1) % entities.Length;
//                    }
//                    return visitedHouses;
//                }
//            }
//        }
//    }
//}