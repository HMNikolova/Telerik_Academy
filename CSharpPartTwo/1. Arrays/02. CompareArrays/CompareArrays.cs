//2. Compare arrays
//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Collections.Generic;
using System.Linq;

class CompareArrays
{
    static void Main()
    {
            Console.WriteLine("Comparing two arrays!");
            Console.Write("Enter size of the first array: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter size of the second array: ");
            int y = int.Parse(Console.ReadLine());
            int[] firstArray = new int[x];
            int[] secondArray = new int[y];
            bool isEqual = true;
            if (x == y)
            {
                Console.WriteLine("Enter {0} numbers for the first array: ", x);
                for (int i = 0; i < x; i++)
                {
                    Console.Write("First Array[{0}] = ", i);
                    firstArray[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter {0} numbers for the second array: ", y);
                for (int i = 0; i < y; i++)
                {
                    Console.Write("Second Array[{0}] = ", i);
                    secondArray[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < x; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        isEqual = false;
                        break;
                    }
                }

            }
            else
            {
                isEqual = false;
            }
            Console.WriteLine("Equal = {0}", isEqual);
        }
    }

