//15. Prime numbers
//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

    class PrimeNumbers
    {
        static void Main()
        {
             bool[] isComplex = new bool[10000000];
        for (int i = 2; i < 10000000; i++)
        {
            if (!isComplex[i])
            {
                Console.Write(" {0},",i);
                int j = i;
                do
                {
                    isComplex[j] = true;
                    j = j + i;
                } while (j < 10000000);
            }
        }
        }
    }

