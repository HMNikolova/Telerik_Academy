//6. The Biggest of Five Numbers
//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
		Console.WriteLine();
		
        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());
		Console.WriteLine();
        Console.Write("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());
		Console.WriteLine();
		Console.Write("Enter the fourth number: ");
        double d = double.Parse(Console.ReadLine());
		Console.WriteLine();
		Console.Write("Enter the fifth number: ");
        double e = double.Parse(Console.ReadLine());
		Console.WriteLine();

        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine("The biggest number is: {0}", a);
        }
        else if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine("The biggest number is: {0}", b);
        }
		else if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine("The biggest number is: {0}", c);
        }
		else if (d > a && d > c && d > b && d > e)
        {
            Console.WriteLine("The biggest number is: {0}", d);
        }
        else
        {
            Console.WriteLine("The biggest number is: {0}", e);
        }
        }
    }

