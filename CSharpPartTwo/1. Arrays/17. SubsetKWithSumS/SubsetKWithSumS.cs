using System;

    class SubsetKWithSumS
    {
        static void Main()
        {
            //17.* Subset K with sum S
            //Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
            //Find in the array a subset of K elements that have sum S or indicate about its absence.

            Console.WriteLine("Please,enter number N ( lenght of array)");
            int numberN = int.Parse(Console.ReadLine());
            Console.WriteLine("Please,enter {0} numbers", numberN);
            int[] myArray = new int[numberN];

            for (int i = 0; i < numberN; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please, enter number K (number of elements for sum)");
            int numberK = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter number S (sum of the elements)");
            int sum = int.Parse(Console.ReadLine());

            int countSubsets = 0;
            int countElements = 0;

            for (int i = 1; i <= Math.Pow(2, myArray.Length) - 1; i++) // If lenght = 8 we need 10 000 000 binary = 128 decimal
            {
                int curentSum = 0;
                for (int j = 0; j < myArray.Length; j++)
                {
                    int mask = 1 << j;        // 00000000 00100000 
                    int nAndMask = i & mask;  // 00000000 00100000
                    int bit = nAndMask >> j;  // 00000000 00000001
                    if (bit == 1)
                    {
                        curentSum += myArray[j]; // sum those with 1 (one) bit 
                        countElements++;
                    }
                }
                if (curentSum == sum && countElements == numberK)
                {
                    countSubsets++;
                }
                countElements = 0;
            }
            if (countSubsets == 0)
            {
                Console.WriteLine("no subsets");
            }
            else
            {
                Console.WriteLine("Yes there is subset of {0} elements that have sum {1}", numberK, sum);
            }
        }
    }

