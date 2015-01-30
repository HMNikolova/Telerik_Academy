//18.* Trailing Zeroes in N!
//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.

using System;
using System.Numerics;

class TrailingZeroesInN
{
    static void Main()
    {
        Console.Write("Enter a integer number (0 - 100000): ");
        int number = int.Parse(Console.ReadLine());
        int result = 0;
        BigInteger factN = 1;
        for (int i = 1; i <= number; i++)
        {
            factN *= i;
        }
        string factorial = factN.ToString();
        int n = factorial.Length;
        n--;
        while (factorial[(n)] == '0')
        {
            result++;
            n--;
        }
        Console.WriteLine("Factorial of number {0}! have {1}", number, result);
    }

}