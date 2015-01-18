//1. Odd or Even Integers
//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Please write an integer: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());
        if (inputNumber % 2 == 0)
        {
            Console.WriteLine(inputNumber + " is even.");
        }
        else
        {
            Console.WriteLine(inputNumber + " is odd.");
        }
    }

}
