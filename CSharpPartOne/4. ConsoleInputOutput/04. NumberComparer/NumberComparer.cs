//4. Number Comparer
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

    class NumberComparer
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            double max = Math.Max(firstNumber, secondNumber);
            Console.WriteLine("The greater number is: {0}\n", max);
        }
    }

