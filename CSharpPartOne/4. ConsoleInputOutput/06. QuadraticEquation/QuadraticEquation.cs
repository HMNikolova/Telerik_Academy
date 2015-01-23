//6. Quadratic Equation
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Quadratic Ecuation");
            Console.WriteLine("Enter 3 coefficients.");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double diskriminant = (b * b) - 4 * a * c;
            double firstX = 0;
            double seconX = 0;

            if (diskriminant < 0)
            {
                Console.WriteLine("No real roots");
            }
            else if (diskriminant > 0)
            {
                firstX = ((-b + Math.Sqrt(diskriminant)) / (2 * a));
                seconX = ((-b - Math.Sqrt(diskriminant)) / (2 * a));
                Console.WriteLine("x1 = {0};", firstX);
                Console.WriteLine("x2 = {0};", seconX);
            }
            else if (diskriminant == 0)
            {
                firstX = seconX = -b / (2 * a);
                Console.WriteLine("x1 = x2 = {0}", firstX);
            }
        }
    }

