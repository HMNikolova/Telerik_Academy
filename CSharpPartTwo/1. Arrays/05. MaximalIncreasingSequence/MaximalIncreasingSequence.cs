//5. Maximal increasing sequence
//Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Collections.Generic;
using System.Linq;

    class MaximalIncreasingSequence
    {
        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int maxSequence = 1;
            int sequence = 1;
            string currentNumber = "";
            string maxNumber = "";
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    sequence++;
                    currentNumber += arr[i] + " ";
                }
                else
                {
                    if (sequence > maxSequence)
                    {
                        maxSequence = sequence;
                        currentNumber += arr[i] + " ";
                        maxNumber = currentNumber;
                    }
                    sequence = 1;
                    currentNumber = "";
                }
            }
            if (sequence > maxSequence)
            {
                currentNumber += arr[arr.Length - 1];
                maxNumber = currentNumber;
            }
            Console.WriteLine(maxNumber);
        }
    }

