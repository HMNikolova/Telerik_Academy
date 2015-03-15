using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Point3D firstP = new Point3D(5.0, 3.2, 3.5);
            Point3D secondP = new Point3D(2.0, 2.5, 3.0);
            Point3D zero = new Point3D();

            Console.WriteLine("Initial Point3D: {0}", zero);
            Console.WriteLine("First Point3D: {0}", firstP);

            Console.WriteLine();
            Console.WriteLine("Distance calculation: {0:F2}", CalculateDistance.DistanceCalc(firstP, secondP));

            Path pathList = new Path();
            pathList.Add(firstP);
            pathList.Add(secondP);

            PathStorage.Save(pathList, @"../../PathStorage.txt");
            PathStorage.Load(@"../../PathStorage.txt");

            Console.WriteLine();
            Console.WriteLine("List of paths stored in the external text file: ");
            foreach (Point3D point in PathStorage.path.PointList)
            {
                Console.WriteLine(point);
            }
            Console.WriteLine();
        }
    }
}
