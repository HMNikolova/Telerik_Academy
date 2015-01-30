//14. Decimal to Binary Number
//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

    class DecimalToBinaryNumber
    {
        static void Main()
        {
            Console.WriteLine("Decimal To Binary Number");
            Console.Write("Enter a number to convert: ");
            long input = long.Parse(Console.ReadLine());
            string number = null;
            while (input > 0)
            {
                if (input % 2 == 0)
                {
                    number += "0";
                }
                else
                {
                    number += "1";
                }

                input = input / 2;
            }
            char[] rev = number.ToCharArray();
            Array.Reverse(rev);
            Console.WriteLine(rev);
        }
    }

