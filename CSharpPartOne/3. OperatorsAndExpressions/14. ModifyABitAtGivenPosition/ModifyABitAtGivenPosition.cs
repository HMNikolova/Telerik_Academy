//14. Modify a Bit at Given Position
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        Console.Write("Enter bit position: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Value of bit 0 or 1: ");
        int v = int.Parse(Console.ReadLine());

        int mask = 1;
        int result;

        if (v == 1)
        {
            mask = mask << p;
            result = n | mask;
        }
        else
        {
            mask = ~(mask << p);
            result = n & mask;
        }
        Console.WriteLine("Binary representation result is  : {0}", Convert.ToString(result, 2).PadLeft(16, '0'));
        Console.WriteLine("Result: {0}", result);

        }
    }

