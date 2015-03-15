using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    public static class CalculateDistance
    {
        public static double DistanceCalc(Point3D first, Point3D second)
        {
            return Math.Sqrt((first.X - second.X) * (first.X - second.X) +
                            (first.Y - second.Y) * (first.Y - second.Y) +
                            (first.Z - second.Z) * (first.Z - second.Z));
        }
    }
}
