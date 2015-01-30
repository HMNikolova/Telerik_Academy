//6. Calculate N! / K!
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;
using System.Numerics;

    class FactorialDivision
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            if (n <= 100 && k > 1)
            {
                for (int i = k + 1; i <= n; i++)
                {
                    result *= i;
                }

            }
            else
            {
                Console.WriteLine("Wrong Input!");
            }
            Console.WriteLine("N!/K!={0}", result);
        }
    }

