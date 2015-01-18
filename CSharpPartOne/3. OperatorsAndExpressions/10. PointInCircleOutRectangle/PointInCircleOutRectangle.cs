//10. Point Inside a Circle & Outside of a Rectangle
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

    class PointInCircleOutRectangle
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers coordinates of a point:");
            double raduis = 1.5;
            Console.Write("Enter x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y = ");
            double y = double.Parse(Console.ReadLine());

            bool ifIsInCircle = (Math.Sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= raduis);
            bool isInRectangle = (-1 < x) ^ (x > 5) ^ (-1 < y) ^ (y > 1);

            if (ifIsInCircle && isInRectangle)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

