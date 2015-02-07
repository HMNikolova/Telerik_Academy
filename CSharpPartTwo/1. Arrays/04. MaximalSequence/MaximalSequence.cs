//4. Maximal sequence
//Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Collections.Generic;
using System.Linq;

    class MaximalSequence
    {
        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int maxSequence = 1;
            int sequence = 1;
            int number = 0;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    sequence++;
                }
                else
                {
                    sequence = 1;
                }
                if (sequence >= maxSequence)
                {
                    maxSequence = sequence;
                    number = arr[i];
                }
            }
            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
    }

