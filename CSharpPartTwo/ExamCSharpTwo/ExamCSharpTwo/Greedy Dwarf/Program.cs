using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy_Dwarf
{
    class Program
    {
        static void Main(string[] args)
        {
             //read valley and number
            int[] valley = ReadArray(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.MinValue;
            for (int i = 0; i < m; i++)
            {
                int[] pattern = ReadArray(Console.ReadLine());
                int currentSum = WorkWithPattern(valley, pattern);
                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                }
            }
            Console.WriteLine(maxSum);
        }

        private static int WorkWithPattern(int[] valley, int[] pattern)
        {
            bool[] isViseted = new bool[valley.Length];
            int currentIndex = 0;
            int currentSum = valley[currentIndex];
            isViseted[currentIndex] = true;
            for (int j = 0; true; j++)
            {
                if (j > pattern.Length - 1)
                {
                    j -= pattern.Length;
                }
                //Joro the rabbit
                //if (j < 0)
                //{
                //    j += pattern.Length;
                //}
                int nextStep = pattern[j];
                currentIndex += nextStep;
                if (currentIndex < 0 ||
                    currentIndex > valley.Length - 1 ||
                    isViseted[currentIndex])
                {
                    break;
                }

                currentSum += valley[currentIndex];
                isViseted[currentIndex] = true;
            }
            return currentSum;
        }

        private static int[] ReadArray(string input)
        {
            int[] arr = input
                .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            return arr;
        }
    }
}
