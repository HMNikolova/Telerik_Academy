//10. Find sum in array
//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;
using System.Collections.Generic;
using System.Linq;

    class FindSumInArray
    {
        static void Main()
        {
            Console.WriteLine("Find sequance in array by given sum!");
            Console.Write("Enter size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write("Enter the sum of the sequance: ");
            int sum = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int currentSum = 0;
            int start = 0;

            for (int i = 0; i < n - 1; i++)
            {
                currentSum += arr[i];
                start = i;
                for (int j = i + 1; j < n; j++)
                {
                    currentSum += arr[j];
                    if (currentSum == sum)
                    {
                        for (int k = start; k <= j; k++)
                        {
                            Console.WriteLine("{0} ", arr[k]);
                        }
                        break;
                    }
                }
                currentSum = 0;
            }
        }
    }

