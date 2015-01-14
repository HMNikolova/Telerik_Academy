/* 8. Square Root
 * Create a console application that calculates and 
 * prints the square root of the number 12345.
 * Find in Internet “how to calculate square root in C#”.
 */

using System;

    class SquareRoot
    {
        static void Main()
        {
            int number = 12345;
            int squareNumber = number * number;
            Console.WriteLine("The square of number {0} is {1}", number, squareNumber);
        }
    }

