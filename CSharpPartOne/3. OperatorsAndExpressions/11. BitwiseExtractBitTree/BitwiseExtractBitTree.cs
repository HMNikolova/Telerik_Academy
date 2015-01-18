//11. Bitwise: Extract Bit #3
//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;

class BitwiseExtractBitTree
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            int moveBitRight = n >> 3;
            int mask = 1;
            int result = moveBitRight & mask;
            Console.WriteLine("Binay type: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("Bit #3 is: {0}", result);
        }
    }

