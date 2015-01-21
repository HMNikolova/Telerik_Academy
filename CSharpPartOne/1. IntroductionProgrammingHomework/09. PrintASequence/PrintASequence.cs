/* 9. Print a Sequence
 * Write a program that prints the first 
 * 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
 */

using System;

    class PrintASequence
    {
        static void Main()
        {
            
            for (int i = 2; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(-i + ", ");
                }
 
            }
            Console.WriteLine();
        }
    }

    //byte counter = 10;

    //Console.WriteLine("Enter the starting number of the sequence: ");
    //int startNumber = int.Parse(Console.ReadLine());

    //for (int i = startNumber; i < startNumber + counter; i++)
    //{
    //    if (i % 2 == 0)
    //    {
    //        Console.Write(i + ", ");
    //    }
    //    else
    //    {
    //        Console.Write(-i + ", ");
    //    }