//4. Maximal sequence
//Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Collections.Generic;
using System.Linq;

    class MaximalSequence
    {
        static void Main()
        {
            Console.Write("Enter numbers with space: ");
            string input = Console.ReadLine();
            string[] numbersString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] nums = new int[numbersString.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(numbersString[i]);
            }

            int[] numbers = input
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n)).ToArray();

            int[] hardcodedNums = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            int currentNum, maxNum = nums[0];
            int currentCount, maxCount = 0;
            for (int i = 0; i < nums.Length; )
            {
                currentNum = nums[i];
                currentCount = 0;
                for (; i < nums.Length; i++)
                {
                    if (currentNum != nums[i])
                    {
                        break;
                    }

                    currentCount++;
                }

                if (maxCount <= currentCount)
                {
                    maxCount = currentCount;
                    maxNum = currentNum;
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(maxNum);
                if (i != maxCount - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }

