 //8. Catalan Numbers
//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

using System;
using System.Numerics;

    class CatalanNumbers
    {
        static void Main()
        {
            int numberN;
            do
            {
                Console.Write("Enter a integer number N (0-100): ");
                numberN = int.Parse(Console.ReadLine()); ;
                if (numberN < 0)
                {
                    Console.WriteLine("N must be greater 0");
                }
                if (numberN > 100)
                {
                    Console.WriteLine("N must be smaller 100");
                }
            }
            while ((numberN < 0) || (numberN > 100));

            BigInteger fact2N = 1;
            BigInteger factN = 1;
            BigInteger result = 0;

            for (int i = 1; i <= 2 * numberN; i++)
            {
                if (i <= numberN)
                {
                    factN = factN * i;
                }
                fact2N = fact2N * i;
            }
            result = fact2N / (factN * factN * (numberN + 1));
            Console.WriteLine("Result = {0}", result);
        }
    }

