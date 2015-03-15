﻿/*
 * Task 4: Create a class Path to hold a sequence of points in the 3D space. 
*/

namespace _01.Point3D
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> listPoint;

        public Path()
        {
            listPoint = new List<Point3D>();
        }

        public List<Point3D> ListPoint
        {
            get { return listPoint; }
        }

        public void Add(Point3D point)
        {
            listPoint.Add(point);
        }
    }
}
