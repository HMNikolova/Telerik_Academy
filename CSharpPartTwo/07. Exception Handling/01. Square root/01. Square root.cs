﻿using System;

class SquareRoot
{
    static void Main()
    {
        /*•	Write a program that reads an integer number and calculates and prints its square root.
            o	If the number is invalid or negative, print Invalid number.
            o	In all cases finally print Good bye.
          •	Use try-catch-finally block.*/
        try
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(input));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Invalid number! {0}", ex.Message);
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}

