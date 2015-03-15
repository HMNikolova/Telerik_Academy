//14. Quick sort
//Write a program that sorts an array of strings using the Quick sort algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

    class QuickSort
    {
        static void Main()
        {
            Console.Write("Enter array by space: ");
            string str = Console.ReadLine();
            List<string> listWord = new List<string>(str.Split(" .,!:-'()}{".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine();
            MyQuickSort(listWord);
            foreach (string s in listWord)
                Console.Write(s + " ");
            Console.WriteLine();
        }

        static void MyQuickSort(List<string> arr)
        {
            if (arr.Count < 2) 
                return;
            string pivot = arr[arr.Count / 2]; 
            List<string> leftArray = new List<string>(); 
            List<string> rightArray = new List<string>(); 

            for (int i = 0; i < arr.Count; i++) 
            {
                if (i == arr.Count / 2) 
                    continue;
                if (string.Compare(arr[i], pivot) < 0)
                    leftArray.Add(arr[i]); 
                else
                    rightArray.Add(arr[i]); 
            }
            MyQuickSort(leftArray); 
            MyQuickSort(rightArray); 
            arr.Clear(); 
            arr.AddRange(leftArray); 
            arr.Add(pivot); 
            arr.AddRange(rightArray); 
        }
    }

