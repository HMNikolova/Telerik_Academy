﻿//4. Multiplication Sign
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;

    class MultiplicationSign
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 numbers: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Result = 0");
            }
            else if (a > 0 || b > 0 || c > 0)
            {
                Console.WriteLine("Result = +");
            }
            else
            {
                Console.WriteLine("Result = -");
            }
        }
    }

