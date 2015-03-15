using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    public struct Point3D
    {
        private double x;
        private double y;
        private double z;
        private static readonly Point3D zero;

        public double X 
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public Point3D Zero 
        {
            get { return zero; }
        }

        public Point3D(double x, double y, double z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        static Point3D()
        {
            zero = new Point3D(0,0,0);
        }

        public override string ToString()
        {
            return string.Format("{0:F1} {1:F1} {2:F1}", this.X, this.Y, this.Z);
        } 

    }
}
