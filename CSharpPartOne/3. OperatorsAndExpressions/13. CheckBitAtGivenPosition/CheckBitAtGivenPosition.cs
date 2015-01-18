//13. Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

    class CheckBitAtGivenPosition
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
            Console.Write("The result value is 1: ");
            if (result == 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }

