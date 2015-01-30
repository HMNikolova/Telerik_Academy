//19.** Spiral Matrix
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

using System;

    class SpiralMatrix
    {
        static void Main()
        {
            Console.WriteLine("Enter a integer number 1 <= N <= 20: ");
            int num = int.Parse(Console.ReadLine()); ;

            int[,] matrix = new int[num, num];
            int row = 0;
            int col = 0;
            string direction = "right";

            int maxCounter = num * num;
            if (1 <= num && num <= 20)
            {
                for (int i = 1; i <= maxCounter; i++)
                {
                    if (direction == "right" && (col > num - 1 || matrix[row, col] != 0))
                    {
                        direction = "down";
                        col--;
                        row++;
                    }
                    else if (direction == "down" && (row > num - 1 || matrix[row, col] != 0))
                    {
                        direction = "left";
                        row--;
                        col--;
                    }
                    else if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                    {
                        direction = "up";
                        col++;
                        row--;
                    }
                    else if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                    {
                        direction = "right";
                        row++;
                        col++;
                    }
                    matrix[row, col] = i;

                    if (direction == "right")
                    {
                        col++;
                    }
                    else if (direction == "down")
                    {
                        row++;
                    }
                    else if (direction == "left")
                    {
                        col--;
                    }
                    else if (direction == "up")
                    {
                        row--;
                    }
                }


                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < num; j++)
                    {
                        Console.Write("{0,4}", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Not a valid number");
            }
            
        }
    }

