using System;

class SortByStringLengh
{
    static void Main()
    {
        //•	You are given an array of strings. Write a method that sorts the array by the length of its 
        //  elements (the number of characters composing them).
        Console.WriteLine("Enter number of elements:");
        int elementsNumber = int.Parse(Console.ReadLine());
        string[] array = new string[elementsNumber];

        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("aray[{0}] = ", i);
            array[i] = Console.ReadLine();
        }

        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
        Console.WriteLine("The sorted array by the length of its elements:");
        Console.WriteLine(string.Join(", ", array));
    }
}
