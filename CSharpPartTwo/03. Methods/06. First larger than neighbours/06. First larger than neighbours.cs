using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        /*•	Write a method that returns the index of the first element in array that is larger than
         *  its neighbours, or -1, if there’s no such element.
          •	Use the method from the previous exercise.*/

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

        int index = FirstLargerThanNeighboursElementAtIndex(numbers);
        Console.WriteLine("First number at index {0}", index);
    }

    private static int FirstLargerThanNeighboursElementAtIndex(int[] array)
    {
        int index = -1;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                index = i;
                break;
            }
        }
        return index;
    }
}
