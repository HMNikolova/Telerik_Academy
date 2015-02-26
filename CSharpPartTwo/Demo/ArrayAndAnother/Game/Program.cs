using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static string ballSymbol = "\u25CF";
        static string brickSymbol = "\u2580";

        static int ballRow;
        static int ballCol;

        static int right = 0;
        static int left = 1;

        static int ballDirection = right;
        static bool goingUp = true;

        static int fieldHeight;
        static int fieldWidth;


        static int[,] bricks;

        static int movesCounter = 0;

        static bool finished;
        static void Main(string[] args)
        {
            SetFieldSize();
            fieldHeight = Console.WindowHeight;
            fieldWidth = Console.WindowWidth;

            Console.OutputEncoding = Encoding.Unicode;

            bricks = new int[fieldHeight, fieldWidth];
            CreateBricks();

            //start position
            ballRow = 17;
            ballCol = Console.WindowHeight / 2;

            PrintBricks();

            int previousRow = ballRow;
            int previousCol = ballCol;

            while (true)
            {
                movesCounter++;

                PrintBall(previousRow, previousCol);
                previousRow = ballRow;
                previousCol = ballCol;

                BounceWalls();
                BreakBricks();

                if (goingUp == true)
                {
                    GoUp();
                }

                else
                {
                    GoDown();
                }

                Thread.Sleep(45);

            }
        }

        static void PrintBall(int previousRow, int previousCol)
        {
            DeleteAtPosition(previousRow, previousCol);
            WriteOnPosition(ballRow, ballCol, ballSymbol, ConsoleColor.White);
            WriteOnPosition(0, 0, movesCounter.ToString(), ConsoleColor.White);

        }
        static void CreateBricks()
        {
            for (int i = 4; i < 9; i++)
            {
                for (int j = 16; j < 46; j++)
                {
                    bricks[i, j] = 1;
                }
            }
        }
        static void PrintBricks()
        {
            for (int i = 0; i < fieldHeight; i++)
            {
                for (int j = 0; j < fieldWidth; j++)
                {
                    if (bricks[i, j] != 0)
                    {
                        WriteOnPosition(i, j, brickSymbol, ConsoleColor.Green);
                    }
                }
            }

        }
        static void BreakBricks()
        {
            if (goingUp == true && bricks[ballRow - 1, ballCol] != 0)
            {
                bricks[ballRow - 1, ballCol] = 0;
                DeleteAtPosition(ballRow - 1, ballCol);
                goingUp = false;
            }
            else if (goingUp == true && ballDirection == right && bricks[ballRow - 1, ballCol + 1] != 0)
            {
                bricks[ballRow - 1, ballCol + 1] = 0;
                DeleteAtPosition(ballRow - 1, ballCol + 1);
                goingUp = false;
            }
            else if (goingUp == true && ballDirection == left && bricks[ballRow - 1, ballCol - 1] != 0)
            {
                bricks[ballRow - 1, ballCol - 1] = 0;
                DeleteAtPosition(ballRow - 1, ballCol - 1);
                goingUp = false;
            }

            if (goingUp == false && bricks[ballRow + 1, ballCol] != 0)
            {
                bricks[ballRow + 1, ballCol] = 0;
                DeleteAtPosition(ballRow + 1, ballCol);
                goingUp = true;
            }

            else if (goingUp == false && ballDirection == right && bricks[ballRow + 1, ballCol + 1] != 0)
            {
                bricks[ballRow + 1, ballCol + 1] = 0;
                DeleteAtPosition(ballRow + 1, ballCol + 1);
                goingUp = true;
            }
            else if (goingUp == false && ballDirection == right && bricks[ballRow + 1, ballCol - 1] != 0)
            {
                bricks[ballRow + 1, ballCol - 1] = 0;
                DeleteAtPosition(ballRow + 1, ballCol - 1);
                goingUp = true;
            }

            if (ballDirection == right && bricks[ballRow, ballCol + 1] != 0)
            {
                bricks[ballRow, ballCol + 1] = 0;
                DeleteAtPosition(ballRow, ballCol + 1);
                ChangeBallDirection();
            }
            else if (ballDirection == right && goingUp == true && bricks[ballRow - 1, ballCol + 1] != 0)
            {
                bricks[ballRow - 1, ballCol + 1] = 0;
                DeleteAtPosition(ballRow - 1, ballCol + 1);
                goingUp = false;
            }
            else if (ballDirection == right && goingUp == false && bricks[ballRow + 1, ballCol + 1] != 0)
            {
                bricks[ballRow + 1, ballCol + 1] = 0;
                DeleteAtPosition(ballRow + 1, ballCol + 1);
                goingUp = true;
            }
            if (ballDirection == left && bricks[ballRow, ballCol - 1] != 0)
            {
                bricks[ballRow, ballCol - 1] = 0;
                DeleteAtPosition(ballRow, ballCol - 1);
                ChangeBallDirection();
            }
            else if (ballDirection == left && goingUp == true && bricks[ballRow - 1, ballCol - 1] != 0)
            {
                bricks[ballRow - 1, ballCol - 1] = 0;
                DeleteAtPosition(ballRow - 1, ballCol - 1);
                goingUp = false;
            }
            else if (ballDirection == left && goingUp == false && bricks[ballRow + 1, ballCol - 1] != 0)
            {
                bricks[ballRow + 1, ballCol + 1] = 0;
                DeleteAtPosition(ballRow + 1, ballCol + 1);
                goingUp = true;
            }
        }

        static void DeleteAtPosition(int row, int col)
        {
            WriteOnPosition(row, col, "\u2588", ConsoleColor.Black);

        }
        static void BounceWalls()
        {
            if (ballRow == 0 || ballRow == fieldHeight - 1)
            {
                goingUp = !goingUp;
            }

            if (ballCol == 0 || ballCol == fieldWidth - 1)
            {
                ChangeBallDirection();
            }

        }

        static void ChangeBallDirection()
        {
            if (ballDirection == left)
            {
                ballDirection = right;
            }
            else if (ballDirection == right)
            {
                ballDirection = left;
            }
        }
        static void GoUp()
        {
            if (ballDirection == right)
            {
                ballRow--;
                ballCol++;
            }
            if (ballDirection == left)
            {
                ballRow--;
                ballCol--;
            }
            if (ballCol == 0 || ballCol == fieldWidth)
            {
                finished = true;
            }
            if (finished)
            {
                return;
            }
        }

        static void GoDown()
        {
            if (ballDirection == right)
            {
                ballRow++;
                ballCol++;
            }
            if (ballDirection == left)
            {
                ballRow++;
                ballCol--;
            }

            if (ballCol == 0 || ballCol == fieldWidth)
            {
                finished = true;
            }
            if (finished)
            {
                return;
            }
        }

        static void SetFieldSize()
        {
            Console.WindowHeight = 20;
            Console.BufferHeight = 20;

            Console.WindowWidth = 60;
            Console.BufferWidth = 60;

        }
        static void WriteOnPosition(int row, int col, string symbol, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(col, row);
            Console.Write(symbol);
        }
    }


}