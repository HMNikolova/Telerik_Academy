//12.* Zero Subset
//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.

using System;
using System.Collections.Generic;

class ZeroSubset
{
    static void Main()
    {
        Console.Write("Enter five integer separated by space: ");
        string input = Console.ReadLine();

        string[] splittedInput = input.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[splittedInput.Length];

        for (int i = 0; i < splittedInput.Length; i++)
        {
            numbers[i] = int.Parse(splittedInput[i]);
        }

        for (int i = 1; i <= 31; i++)
        {
            List<int> subSetNumbers = new List<int>();
            int sum = 0;

            for (int j = 0; j < numbers.Length; j++)
            {
                int bit = (i >> j) & 1;

                if (bit == 1)
                {
                    sum += numbers[j];
                    subSetNumbers.Add(numbers[j]);
                }
            }
            if (sum == 0)
            {
                for (int j = 0; j < subSetNumbers.Count; j++)
                {
                    if (j == subSetNumbers.Count - 1)
                    {
                        Console.Write("{0}", subSetNumbers[j]);
                    }
                    else
                    {
                        Console.Write("{0} + ", subSetNumbers[j]);
                    } 
                }
                Console.WriteLine(" = " + sum);
            }
        }
    }
}
