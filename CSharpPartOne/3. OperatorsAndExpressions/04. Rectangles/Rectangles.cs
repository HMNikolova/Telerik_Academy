//4. Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

    class Rectangles
    {
        static void Main()
        {
            Console.Write("Please enter widht: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Please enter height: ");
            double height = double.Parse(Console.ReadLine());
            double perimeter = (width + height) * 2;
            double area = width * height;
            Console.WriteLine("Perimeter is: {0}", perimeter);
            Console.WriteLine("Area is: {0} ", area);
        }
    }

