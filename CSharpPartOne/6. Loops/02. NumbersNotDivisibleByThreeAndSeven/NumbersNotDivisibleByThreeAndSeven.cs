//2. Numbers Not Divisible by 3 and 7
//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.

using System;

    class NumbersNotDivisibleByThreeAndSeven
    {
        static void Main()
        {
            Console.Write("Enter a positive integer: ");
            uint n = uint.Parse(Console.ReadLine());
            
            for (uint i = 1; i <= n; i++)
            {
                if (i % 7 != 0 && i % 3 != 0)
                {
                    Console.Write(i + " ");
                }
                
            }
            
        }
    }

