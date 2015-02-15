using System;

class BinarySearch
{
    static void Main()
    {
        /*•	Write a program, that reads from the console an array of N integers and an integer K, 
         * sorts the array and using the method Array.BinSearch() finds the largest number in the 
         * array which is ≤ K.*/
        Console.WriteLine("Enter elements' number in an array:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter integer for k:");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Enter the elements:");

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        Console.WriteLine("This is the sorted array:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();

        if (array[0] > k)
        {
            Console.WriteLine("There is no number in the array which is equal or less than {0}.", k);
        }

        for (int i = k; i >= 0; i--)
        {
            if (Array.BinarySearch(array, i) >= 0)
            {
                Console.WriteLine("The largest number in the array which is equal or less than {0} is {1}.", k, i);
                return;
            }
        }
    }
}

