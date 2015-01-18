//7. Point in a Circle
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

    class PointInACircle
    {
        static void Main()
        {
            Console.WriteLine("Enter point coordinates (x,y) to check if is inside in the circle K(O, 2): ");
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());
            bool circleRadius = ((x * x) + (y * y) <= 2 * 2);
            Console.WriteLine(circleRadius);
        }
    }

