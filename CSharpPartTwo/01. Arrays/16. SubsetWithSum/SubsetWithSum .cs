using System;

class SubsetWithSum
{
    static void Main()
    {
        //•	We are given an array of integers and a number S.
        //•	Write a program to find if there exists a subset of the elements of the array that has a sum S.

        Console.Write("Enter a sum to look for: ");
        long S = long.Parse(Console.ReadLine());
        long[] input = { 2, 1, 2, 4, 3, 5, 2, 6 };
        long currentSum = 0;
        int count = 0;

        for (int i = 1; i <= (int)Math.Pow(2, input.Length) - 1; i++)
        {
            currentSum = 0;
            string temp = Convert.ToString(i, 2).PadLeft(input.Length, '0');

            for (int j = 0; j < temp.Length; j++)
            {
                if (temp[j].ToString() == "1")
                {
                    currentSum += input[j];
                }
            }
            if (currentSum == S)
            {
                count++;
            }
        }
        if (count > 0)
        {
            Console.WriteLine("Yes, {0} combinations of elements in the array [{1}] have a sum of {2}.", count, string.Join(", ", input), S);
        }
    }
}