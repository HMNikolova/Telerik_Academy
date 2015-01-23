// 7. Sum of 5 Numbers
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter five numbers given in a single line, separated by a space");
            string[] fiveNumber = Console.ReadLine().Split(' ');
            double sum = 0;
            for (int i = 0; i < fiveNumber.Length; i++)
            {
                sum += Convert.ToDouble(fiveNumber[i]);
            }
            Console.WriteLine("Sum is = {0}", sum);
        }
    }

