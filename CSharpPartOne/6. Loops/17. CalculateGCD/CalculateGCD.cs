//17.* Calculate GCD
//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

using System;

    class CalculateGCD
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            if (a == 0)
            {
                Console.WriteLine("GCD = {0}", b);
            }
            else
            {
                Console.WriteLine("GCD = {0}", a);
            }
        
        }
    }

