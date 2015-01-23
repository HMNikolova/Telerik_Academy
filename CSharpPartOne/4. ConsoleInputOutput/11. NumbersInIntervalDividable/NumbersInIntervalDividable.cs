//11.* Numbers in Interval Dividable by Given Number
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;

    class NumbersInIntervalDividable
    {
        static void Main()
        {
            Console.WriteLine("Enter first integer number: ");
            int firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer number: ");
            int secondInt = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = firstInt; i <= secondInt; i++)
            {

                if (i % 5 == 0)
                {
                    count++;
                    Console.Write("{0}, ", i);
                }
            }
            Console.WriteLine("there are {0} numbers between {1} and {2}, that the reminder of their division by 5 is 0"
                                , count, firstInt, secondInt);
        }
    }

