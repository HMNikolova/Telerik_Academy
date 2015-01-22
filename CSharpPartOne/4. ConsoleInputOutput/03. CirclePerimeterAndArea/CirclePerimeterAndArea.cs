//3. Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Enter radius of a circle: ");
            double radius = double.Parse(Console.ReadLine());

            double perimetar = 2 * Math.PI * radius;
            double area = Math.PI * (radius * radius);
            Console.WriteLine("Perimeter of circle is: {0:F2}", perimetar);
            Console.WriteLine("Area of circle is: {0:F2}", area);
        }
    }

