//6. Four-Digit Number
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;

    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Enter a 4 digits nubmer: ");
            int n = int.Parse(Console.ReadLine());
            int a = (n / 1000) % 10;
            int b = (n / 100) % 10;
            int c = (n / 10) % 10;
            int d = n % 10;
            int sum = a + b + c + d;
            Console.WriteLine("Sum of digits: {0}", sum);
            Console.WriteLine("Reversed digits: {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("Last is first: {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("Second is third: {0}{1}{2}{3}", a, c, b, d);
        }
    }

