using System;

class SumIntegers
{
    static void Main()
    {
        //•	You are given a sequence of positive integer values written into a string, separated by spaces.
        //•	Write a function that reads these values from given string and calculates their sum.
         Console.WriteLine("Enter array of integers, separated by spaces (1 2 3 ...): ");
         Console.WriteLine("Enter positive integers, separated by spaces:");
         string input = Console.ReadLine();
         Console.WriteLine("The sum is: {0}", SumOfIntegers(input));
    }

    private static uint SumOfIntegers(string input)
    {
        string[] numbers = input.Split(' ');
        uint sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += uint.Parse(numbers[i]);
        }

        return sum;
    }
    }


