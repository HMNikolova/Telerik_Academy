using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Arrays_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string colsLine = Console.ReadLine();
                //разцепване на стринга на отделни стойности
                //и понеже colsLine е string може да използваме върху него метода Split
                string[] cells = colsLine.Split(' ');
                //Console.WriteLine(string.Join(", ", cells));
                for (int col = 0; col < matrix.GetLength(1); col++)
                //или for (int col = 0; col < cells.Length; col++)
                //но е хубаво да се направи една проверка
                //check iff cells.Length == matrix.GetLength(1)
                {
                    //конвертиране: int n = int.Parse("5") или Convert.ToInt32("5")
                    matrix[row, col] = int.Parse(cells[col]);
                }
            }

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write("{0}", matrix[row, col]);
            //        if (col != matrix.GetLength(1) - 1)
            //        {
            //            Console.Write(", ");
            //        }

            //    }
            //    Console.WriteLine();
            //}

            //int[,] matrix =
            //{
            //    {1,2,3},
            //    {4,5,6},
            //    {7,8,9},
            //    {10,11,12}
            //};
            //Console.WriteLine(matrix[2, 1]);

            //int rows = int.Parse(Console.ReadLine());
            //int cols = int.Parse(Console.ReadLine());
            //int[,] matrix = new int[rows, cols];

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write("matrix[{0}, {1}] = ", row, col);
            //        matrix[row, col] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write("{0}", matrix[row, col]);
            //        if (col != matrix.GetLength(1) - 1)
            //        {
            //            Console.Write(", ");
            //        }
                    
            //    }
            //    Console.WriteLine();
            //}
            //    int[, ,] cube = new int[3, 4, 5];
            //    //GetLength дай ми дължината в конкретно измерение
            //    //string result = string.Empty;
            //    //Console.WriteLine(cube.Rank); //колко измерения има масива
            //        for (int x = 0; x < cube.GetLength(0); x++)
            //        {
            //            for (int y = 0; y < cube.GetLength(1); y++)
            //            {
            //                for (int z = 0; z < cube.GetLength(2); z++)
            //                {
            //                    cube[x, y, z] = x * y * z;
            //                }
            //            }
            //        }


            //    Console.WriteLine("Cell at [1,2,3]: {0}", cube[1, 2, 3]);
            //    Console.WriteLine("Last cell: {0}", cube[2, 3, 4]);
            //}
        }
    }
}