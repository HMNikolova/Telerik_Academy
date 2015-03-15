using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    public class Path
    {
        private List<Point3D> pointList;

        public Path()
        {
            pointList = new List<Point3D>();
        }

        public List<Point3D> PointList 
        {
            get { return pointList; }
        }

        public void Add(Point3D point)
        {
            pointList.Add(point);
        }
    }
}
