using System;

class LargerThanNeighbours
{
    
        //•	Write a method that checks if the element at given position in given array of integers is larger than 
        //  its two neighbours (when such exist).

    static void Main()
    {
        Console.Write("Enter arrays length: ");
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int[length];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Array[{0}] = ", i);
            string input = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(input, out number);
            if (isNumber)
            {
                numbers[i] = number;
            }
        }
        Console.Write("Index: ");
        int index = int.Parse(Console.ReadLine());
        if (isLargerByNeighbors(numbers, index))
        {
            Console.WriteLine("Element on position {0} is bigger than its two neighbors", index);
        }
        else
        {
            Console.WriteLine("Element on position {0} is not bigger from its two neighbors", index);

        }
    }

    static bool isLargerByNeighbors(int[] array, int position)
    {
        bool check = false;
        if ((position > 0) && (position < array.Length - 1))
        {
            if ((array[position] > array[position - 1]) && (array[position] > array[position + 1]))
            {
                check = true;
            }
        }
        if (position == 0)
        {
            if ((array[position] > array[position + 1]) && (array[position] > array[array.Length]))
            {
                check = true;
            }
        }
        if (position == array.Length - 1)
        {
            if ((array[position] > array[position - 1]) && (array[position] > array[0]))
            {
                check = true;
            }
        }
        return check;
    }
}