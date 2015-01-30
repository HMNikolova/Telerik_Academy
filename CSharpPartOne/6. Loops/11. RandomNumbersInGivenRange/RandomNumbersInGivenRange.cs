//11. Random Numbers in Given Range
//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            Console.WriteLine("Random Number In Given Range");
            Console.Write("Enter 3 numbers: ");
            int nums, min, max;
            Console.Write("numbers n = ");
            nums = int.Parse(Console.ReadLine());
            Console.Write("min of range = ");
            min = int.Parse(Console.ReadLine());
            Console.Write("max of range = ");
            max = int.Parse(Console.ReadLine());
            if (min >= max)
            {
                Console.WriteLine("invalid Period");
            }
            else
            {
                Random randomGenerator = new Random();
                for (int i = 0; i < nums; i++)
                {
                    Console.Write("{0} ", randomGenerator.Next(min, max));
                }
                Console.WriteLine();
            }


        }
    }


