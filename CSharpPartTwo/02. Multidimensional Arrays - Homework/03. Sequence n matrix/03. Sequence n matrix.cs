using System;
using System.Collections.Generic;

class SequenceNMatrix
{
    static void Main()
    {
        /* •	We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets 
             of several neighbour elements located on the same line, column or diagonal.
           • Write a program that finds the longest sequence of equal strings in the matrix.*/
        Console.WriteLine("Enter rows' number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter columns' number:");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("matrix[{0},{1}] = ", i, j);
                string element = Console.ReadLine();
                matrix[i, j] = element;
            }
        }

        Console.WriteLine("This is the matrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0}  ", matrix[i, j]);
            }
            Console.WriteLine();
        }

        int counter = 1;
        int maxCount = 0;
        int currentRow = 0;
        int currentCol = 0;
        List<string> elementsList = new List<string>();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if ((col < matrix.GetLength(1) - 1) && (matrix[row, col + 1] == matrix[row, col]))
                {
                    currentCol = col + 1;

                    while ((currentCol < matrix.GetLength(1)) && (matrix[row, currentCol] == matrix[row, col]))
                    {
                        counter++;
                        currentCol++;

                        if (counter > maxCount)
                        {
                            maxCount = counter;
                            elementsList.Clear();
                            elementsList.Add(matrix[row, col]);
                        }
                        else if (counter == maxCount)
                        {
                            elementsList.Add(matrix[row, col]);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    currentCol = 0;
                    counter = 1;
                }

                if ((row < matrix.GetLength(0) - 1) && (col < matrix.GetLength(1) - 1) &&
                    (matrix[row + 1, col + 1] == matrix[row, col]))
                {
                    currentCol = col + 1;
                    currentRow = row + 1;

                    while ((currentRow < matrix.GetLength(0)) && (currentCol < matrix.GetLength(1)) &&
                           (matrix[currentRow, currentCol] == matrix[row, col]))
                    {
                        counter++;
                        currentRow++;
                        currentCol++;
                        if (counter > maxCount)
                        {
                            maxCount = counter;
                            elementsList.Clear();
                            elementsList.Add(matrix[row, col]);
                        }
                        else if (counter == maxCount)
                        {
                            elementsList.Add(matrix[row, col]);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    currentRow = 0;
                    currentCol = 0;
                    counter = 1;
                }

                if ((row < matrix.GetLength(0) - 1) && (matrix[row + 1, col] == matrix[row, col]))
                {
                    currentRow = row + 1;

                    while ((currentRow < matrix.GetLength(0)) && (matrix[currentRow, col] == matrix[row, col]))
                    {
                        counter++;
                        currentRow++;
                        if (counter > maxCount)
                        {
                            maxCount = counter;
                            elementsList.Clear();
                            elementsList.Add(matrix[row, col]);
                        }
                        else if (counter == maxCount)
                        {
                            elementsList.Add(matrix[row, col]);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    currentRow = 0;
                    counter = 1;
                }

                if ((row < matrix.GetLength(0) - 1) && (col > 0) && (matrix[row + 1, col - 1] == matrix[row, col]))
                {
                    currentRow = row + 1;
                    currentCol = col - 1;

                    while ((currentRow < matrix.GetLength(0)) && (currentCol >= 0) &&
                           (matrix[currentRow, currentCol] == matrix[row, col]))
                    {
                        counter++;
                        currentRow++;
                        currentCol--;
                        if (counter > maxCount)
                        {
                            maxCount = counter;
                            elementsList.Clear();
                            elementsList.Add(matrix[row, col]);
                        }
                        else if (counter == maxCount)
                        {
                            elementsList.Add(matrix[row, col]);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    currentRow = 0;
                    currentCol = 0;
                    counter = 1;
                }
            }
        }

        Console.WriteLine("The longest sequence(es) of equal strings in the matrix:");

        if (maxCount > 0)
        {
            foreach (string item in elementsList)
            {
                for (int i = 0; i < maxCount; i++)
                {
                    if (i < maxCount - 1)
                    {
                        Console.Write("{0}, ", item);
                    }
                    else
                    {
                        Console.Write("{0}", item);
                    }
                }
                Console.WriteLine();
            }
        }
        else
        {
            foreach (string item in matrix)
            {
                Console.WriteLine(item);
            }
        }
    }

}