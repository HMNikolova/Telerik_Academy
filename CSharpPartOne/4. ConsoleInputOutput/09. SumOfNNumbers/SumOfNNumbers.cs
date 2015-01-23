//9. Sum of n Numbers
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

using System;

    class SumOfNNumbers
    {
        static void Main()
        {
            Console.WriteLine("Sum of n numbers");
            Console.Write("Enter how many numbers you will enter: ");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} numbers", num);
            double sum = 0;
            for (int i = 1; i <= num; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                sum = sum + numbers;
            }
            Console.WriteLine("sum of your numbers is = {0}", sum);
        }
    }

