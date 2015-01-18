//15.* Bits Exchange
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

    class BitsExchange
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            int mask = ((7 << 3) | (7 << 24));
            int firstBitGroup = (number >> 3) & 7;
            int secondBitGroup = (number >> 24) & 7;
            Console.WriteLine((number & (~mask)) | ((firstBitGroup << 24) | (secondBitGroup << 3)));
 
          
        }
    }

