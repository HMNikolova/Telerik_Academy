using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = 
            {
              {7, 1, 3, 3, 2, 1},
              {1, 3, 9, 8, 9, 9},
              {4, 6, 7, 9, 9, 9} 
            };
            if (matrix.GetLength(0) < 2 || matrix.GetLength(1) < 2)
            {
                Console.WriteLine("Not a valid matrix");
                return;
            }
            int bestRow = 0;
            int bestCol = 0;
            int bestSum = matrix[0, 0] + matrix[0, 1] +
                matrix[1, 0] + matrix[1, 1];
            //int bestSum = int.MinValue; - горните 2 реда могат да се представят и така

            for (int row = 0; row < matrix.GetLength(0) -1; row++)
            {
              
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int newSum = matrix[row, col] + matrix[row, col + 1] +
                matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (bestSum < newSum)
                    {
                        bestSum = newSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine("Best matrix: ");
            Console.WriteLine("{0} {1}", matrix[bestRow, bestCol], matrix[bestRow, bestCol+1]);
            Console.WriteLine("{0} {1}", matrix[bestRow+1, bestCol], matrix[bestRow+1, bestCol + 1]);
            Console.WriteLine("Best sum is: {0}", bestSum);



















            //int[,] matrix = 
            //{
            //  {7, 1, 3, 3, 2, 1},
            //  {1, 3, 9, 8, 5, 6},
            //  {4, 6, 7, 9, 1, 0} 
            //};
            //if (matrix.GetLength(0)<2 || matrix.GetLength(1)<2)
            //{
            //    Console.WriteLine("Not a valid matrix");
            //    return;
            //}
            //int bestSum = matrix[0, 0] + matrix[0, 1] +
            //    matrix[1, 0] + matrix[1, 1];
            ////int bestSum = int.MinValue; - горните 2 реда могат да се представят и така

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    if (row == matrix.GetLength(0)-1)
            //    {
            //        continue;
            //    }
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        if (col == matrix.GetLength(1)-1)
            //        {
            //            continue;
            //        }
            //        int newSum = matrix[row, col] + matrix[row, col+1] +
            //    matrix[row+1, col] + matrix[row+1, col+1];
            //        if (bestSum < newSum)
            //        {
            //            bestSum = newSum;
            //        }
            //    }
            //}
            //Console.WriteLine("Best sum is: {0}", bestSum);
        }
    }
}
