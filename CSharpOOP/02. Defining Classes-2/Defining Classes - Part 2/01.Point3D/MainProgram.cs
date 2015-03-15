﻿/*
 * Task from 1 to 4
 */

namespace _01.Point3D
{
    using System;

    class MainProgram
    {
        static void Main()
        {
            Point3D firstP = new Point3D(1.2, 2.3, 3.4);
            Point3D secondP = new Point3D(1.3, 2.4, 3.5);
            Point3D zero = new Point3D();

            Console.WriteLine("Initial Point3D: {0}", zero);
            Console.WriteLine("First Point3D: {0}", firstP);

            Console.WriteLine();
            Console.WriteLine("Distance calculation: {0:F2}", CalculateDistance.DistanceCalc(firstP, secondP));

            Path pathList = new Path();
            pathList.Add(firstP);
            pathList.Add(secondP);

            PathStorage.Save(pathList, @"../../PathStoring.txt");
            PathStorage.Load(@"../../PathStoring.txt");

            Console.WriteLine();
            Console.WriteLine("List of paths stored in the external text file: ");
            foreach (Point3D point in PathStorage.path.ListPoint)
            {
                Console.WriteLine(point);
            }

            Console.WriteLine();
        }
    }
}