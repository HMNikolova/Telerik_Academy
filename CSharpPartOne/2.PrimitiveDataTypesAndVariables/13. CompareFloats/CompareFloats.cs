//13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;

class CompareFloats
{
    static void Main()
    {
        Console.Write("Write a floating number: ");
        double firstPointNumber = Double.Parse(Console.ReadLine());
        Console.Write("Write a float number: ");
        double secondPointNumber = Double.Parse(Console.ReadLine());
        bool compare = Math.Abs(firstPointNumber - secondPointNumber) < 0.000001;

        Console.WriteLine("The two compared floating numbers are: {0}", compare);
        }
    }

