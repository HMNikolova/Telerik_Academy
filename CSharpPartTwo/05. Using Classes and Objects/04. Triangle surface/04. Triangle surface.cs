using System;

class TriangleSurface
{
        /*•	Write methods that calculate the surface of a triangle by given:
            o	Side and an altitude to it;
            o	Three sides;
            o	Two sides and an angle between them;
          •	Use System.Math.*/
    static void Main()
    {
        Console.WriteLine("Choose a method for calculating triangle area: \n" +
                          "1. By side and an altitude to it\n" +
                          "2. By three sides\n" +
                          "3. By two sides and the angle between them");
        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1: Console.WriteLine("Enter side length: ");
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter altitude length: ");
                double altitude = double.Parse(Console.ReadLine());
                Console.WriteLine("The area is: {0}", AreaBySideAndAltitude(side, altitude));
                break;
            case 2: Console.WriteLine("Enter side a length: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side b length: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side c length: ");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine("Thea area is: {0}", AreaByThreeSides(a, b, c));
                break;
            case 3: Console.WriteLine("Enter side length: ");
                double firstSide = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter another side length: ");
                double secondSide = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the degrees of the angle between these sides: ");
                double angle = double.Parse(Console.ReadLine());
                Console.WriteLine("Thea area is: {0}", AreaByTwoSidesAndAngle(firstSide, secondSide, angle));
                break;
        }
        Main();
    }

    static double AreaBySideAndAltitude(double side, double altitude)
    {
        double area = side * altitude / 2;
        return area;
    }

    static double AreaByThreeSides(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double area = Math.Sqrt((p) * (p - a) * (p - b) * (p - c));
        return area;
    }

    static double AreaByTwoSidesAndAngle(double a, double b, double angle)
    {
        double area = (a * b * Math.Sin(angle * Math.PI / 180)) / 2; 
        return area;
    }
    }
  


