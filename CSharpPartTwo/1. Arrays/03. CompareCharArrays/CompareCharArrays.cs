//3. Compare char arrays
//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Collections.Generic;
using System.Linq;

    class CompareCharArrays
    {
        static void Main()
        {
            Console.WriteLine("Comparing two char arrays!");
            Console.Write("Enter size of the first array: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter size of the second array: ");
            int y = int.Parse(Console.ReadLine());
            char[] firstArray = new char[x];
            char[] secondArray = new char[y];
            bool isEqual = true;
            if (x == y)
            {
                Console.WriteLine("Enter {0} chars for the first array: ", x);
                for (int i = 0; i < x; i++)
                {
                    Console.Write("First Array[{0}] = ", i);
                    firstArray[i] = char.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter {0} chars for the second array: ", y);
                for (int i = 0; i < y; i++)
                {
                    Console.Write("Second Array[{0}] = ", i);
                    secondArray[i] = char.Parse(Console.ReadLine());
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

