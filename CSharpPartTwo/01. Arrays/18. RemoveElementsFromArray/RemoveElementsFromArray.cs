using System;
using System.Collections.Generic;
using System.Linq;
    class RemoveElementsFromArray
    {
        static void Main()
        {
            ﻿//Problem 18.* Remove elements from array
            //Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
            //Print the remaining sorted array.

            Console.Write("Enter how many element will be in the array N=");
            int n = int.Parse(Console.ReadLine());
            List<int> array = new List<int>();// { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            for (int i = 0; i < n; i++)
            {
                Console.Write("element[{0}]=", i);
                array.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < array.Count - 1; i++)
            {
                if (array[i] > array[i + 1] || array[i] < array[0])
                {
                    array.Remove(array[i]);
                }
            }
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write(i < array.Count - 1 ? array[i] + ", " : array[i] + "\n");
            }
        }
    }

