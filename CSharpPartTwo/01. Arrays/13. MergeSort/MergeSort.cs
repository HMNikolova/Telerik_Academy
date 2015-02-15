//3.* Merge sort
//Write a program that sorts an array of integers using the Merge sort algorithm.


using System;
using System.Collections.Generic;
using System.Linq;

    class MergeSort
    {
        static void Main()
        {
            Console.WriteLine("Enter array separeted by comma: ");
            int[] array = Console.ReadLine().Split(new char[] { ' ', ',', '\t' },
                          StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            int[] n = new int[array.Length];

            Console.WriteLine("Before sorting: {0}", string.Join(" ", array));

            MergeSort(array, n, 0, array.Length - 1);

            Console.WriteLine("After sorting: {0}\n", string.Join(" ", array));
        }

        static void MergeSort(int[] elements, int[] temp, int start, int end)
        {
            if (start >= end) return;

            int middle = (start + end) / 2;

            MergeSort(elements, temp, start, middle);
            MergeSort(elements, temp, middle + 1, end);

            CompareAndSort(elements, temp, start, middle, end);
        }

        static void CompareAndSort(int[] elements, int[] temp, int start, int middle, int end)
        {
            int i = start;
            int l = start, m = middle + 1;

            while (l <= middle && m <= end)
                temp[i++] = (elements[l] > elements[m]) ? elements[m++] : elements[l++];

            while (l <= middle) temp[i++] = elements[l++];

            while (m <= end) temp[i++] = elements[m++];

            for (int j = start; j <= end; j++) elements[j] = temp[j];
        }
    }

