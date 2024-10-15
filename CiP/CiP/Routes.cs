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
        public static void RouteCalculator()
        {
           string directions = ReadFile.ReadFileFunction(); 
            HashSet<(int, int)> visitedHouses =new HashSet<(int, int)> ();
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
        }
    }
}
