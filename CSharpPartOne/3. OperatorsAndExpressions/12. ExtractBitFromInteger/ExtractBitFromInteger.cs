//12. Extract Bit from Integer
//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position: ");
        int p = int.Parse(Console.ReadLine());
        int moveBitRight = n >> p;
        int mask = 1;
        int result = moveBitRight & mask;
        Console.WriteLine("Binay type: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("The result is: {0}", result);
    }
}