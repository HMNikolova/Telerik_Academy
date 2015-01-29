//3. Min, Max, Sum and Average of N Numbers
//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Please, enter interger number of sequence of numbers: ");
        int n = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        double average = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter integer {0}: ", i + 1);
            int num = int.Parse(Console.ReadLine());
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
            sum += num;
        }

        average = (double)sum / n;
        Console.WriteLine("min = " + min);
        Console.WriteLine("max = " + max);
        Console.WriteLine("sum = " + sum);
        Console.WriteLine("average = {0:f2}", average);
    }
    }

