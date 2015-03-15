//8. Maximal sum
//Write a program that finds the sequence of maximal sum in given array.

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Calculating the maximal sum of sequance in an array.");
        Console.Write("Enter size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        long maxSum = array[0];
        long currentSum = array[0];
        int currentSeqStart = 0;
        int maxSumSeqStart = 0;
        int maxSumSeqLength = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == 0)
            {
                continue;
            }
            if ((currentSum + array[i] > currentSum) || (array[i - 1] >= array[i]))
            {
                currentSum += array[i];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumSeqStart = currentSeqStart;
                    maxSumSeqLength++;
                }
            }
            else
            {
                i++;
                currentSeqStart = i;
                currentSum = array[i];
            }
        }

        int[] maxSequence = new int[maxSumSeqLength];
        for (int i = 0; i < maxSequence.Length; i++)
        {
            maxSequence[i] = array[maxSumSeqStart + i];
        }

        Console.WriteLine("The max sum is {0}.", maxSum);
        Console.WriteLine("Sequence in the array [{0}] is [{1}]", String.Join(", ", array), String.Join(", ", maxSequence));
       
        }
    }


