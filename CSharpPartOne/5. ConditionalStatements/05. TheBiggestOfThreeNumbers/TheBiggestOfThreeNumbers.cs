﻿//5. The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers.

using System;

    class TheBiggestOfThreeNumbers
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double c = double.Parse(Console.ReadLine());
    
            if (a > b && a > c)
            {
                Console.WriteLine("The biggest number is: {0}", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("The biggest number is: {0}", b);
            }
            else
            {
                Console.WriteLine("The biggest number is: {0}", c);
            }
        }
    }

