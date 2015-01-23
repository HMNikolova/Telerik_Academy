//8. Numbers from 1 to n
//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
//Note: You may need to use a for-loop.

using System;

    class NumbersFromOneToN
    {
        static void Main()
        {
            Console.WriteLine("Numbers from 1 to n");
            Console.Write("Enter number n =");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

