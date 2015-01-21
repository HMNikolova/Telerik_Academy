/*16.* Print Long Sequence
 * Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
 * You might need to learn how to use loops in C# (search in Internet).
 */

using System;

    class PrintLongSequence
    {
        static void Main()
        {

            for (int i = 0, num = 2; i < 1000; i++, num++)
            {
                if (num % 2 == 0)
                {
                    Console.Write("{0},", num);
                }
                else
                {
                    num = num * (-1);
                    Console.Write("{0},", num);
                    num = num * (-1);
                }
            }
            Console.WriteLine();
        }
    }
