using System;

    class PermutationsOfSet
    {
        static void Main()
        {
            // 19.* Permutations of set
            //Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

            int n = 5;
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            Permutation(arr, 0, arr.Length - 1);
        }

        private static void Permutation(int[] arr, int index, int length)
        {
            if (index == length)
            {
                Console.WriteLine(string.Join(", ", arr));
                return;
            } 

            for (int i = index; i < arr.Length; i++)
            {
                    Swap(arr, i, index);
                    Permutation(arr, index + 1, length);
                    Swap(arr, i, index);
                
            }
        }
        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

        }
    }

