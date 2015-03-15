//11. Binary search
//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
  
using System;
using System.Collections.Generic;
using System.Linq;

    class BinarySearch
    {
        static void Main()
        {
            int[] n = Enumerable.Range(-20, 40).ToArray();//makes us an array of 40 index (-20 start, 40 is range)
            Console.WriteLine("Enter key:");
            int key = int.Parse(Console.ReadLine());
            int lowerBound = 0, upperBound = n.Length, index = lowerBound + (upperBound - lowerBound) / 2;
            
            do
            {
                if (key > n[index])
                {
                    lowerBound = index;
                }
                else if (key < n[index])
                {
                    upperBound = index;
                }
                index = lowerBound + (upperBound - lowerBound) / 2;

            } while (n[index] != key && upperBound - lowerBound > 1);

            Console.WriteLine(n[index] == key ? "Item with key {0} was found at {1}" : "Item with key {0} was not found", key, index);
        }
    }

