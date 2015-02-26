﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontBeAngry
{
    public static class DontBeAngry
    {
        static int[] player1Figures = { 1, 1, 1, 1 }; //PrintAtPosition(2, 19, "\u25cb"); circle
        static int[] player2Figures = { 1, 1, 1, 1 }; //PrintAtPosition(2, 19, "\u25b2"); triangle
        static int[] player3Figures = { 1, 1, 1, 1 }; //PrintAtPosition(2, 19, "\u25a0"); square
        static int[] player4Figures = { 1, 1, 1, 1 }; //PrintAtPosition(2, 19, "X"); cross
        static byte currentPlayer = 1;
        static Random randomGenerator = new Random();
        static int diceNumber = 0;
        static int[,] gameFigures = { {0,  0,   0,   0,  1, 0, 0, 0, 0, 0, 0},
                                      {0,  40,  41,  0,  0, -1, 0, 0, 30, 31, 0},
                                      {0,  42,  43,  0,  0, -1, 0, 0, 32, 33, 0},
                                      {0,  0,   0,   0,  0, -1, 0, 0, 0, 0, 0},
                                      {0,  0,   0,   0,  0, -1, 0, 0, 0, 0, -1},
                                      {0,  -1,  -1,  -1, -1, 0, -1, -1, -1, -1, 0},
                                      {-1,  0,  0,   0,  0, -1, 0, 0, 0, 0, 0},
                                      {0,  0,   0,   0,  0, -1, 0, 0, 0, 0, 0},
                                      {0,  10,  11,  0,  0, -1, 0, 0, 20, 21, 0},
                                      {0,  12,  13,  0,  0, -1, 0, 0, 22, 23, 0},
                                      {0,  0,   0,   0,  0, 0, -1, 0, 0, 0, 0} };
        static void Main()
        {
            DrawGameField();
            GameLogic();
        }
        static void GameLogic()
        {
            while (true)
            {
                ClearConsoleArea(10, 56, 0);
                DrawGameFigures();
                if (currentPlayer == 1) PrintAtPosition(56, 0, "Red player turn", ConsoleColor.White, ConsoleColor.Red);
                else if (currentPlayer == 2) PrintAtPosition(56, 0, "Blue player turn", ConsoleColor.White, ConsoleColor.Blue);
                else if (currentPlayer == 3) PrintAtPosition(56, 0, "Yellow player turn", ConsoleColor.White, ConsoleColor.Yellow);
                else PrintAtPosition(56, 0, "Green player turn", ConsoleColor.White, ConsoleColor.Green);
                PrintAtPosition(56, 3, "Press [enter] to roll");
                WaitForKey(ConsoleKey.Enter);
                ClearConsoleArea(1, 56, 3);
                diceNumber = randomGenerator.Next(1, 7);
                //diceNumber = 6;
                PrintAtPosition(56, 3, "Dice shows: " + diceNumber);
                ActionAfterRoll();
                if (diceNumber != 6) currentPlayer++;
                if (currentPlayer == 5) currentPlayer = 1;
            }
        }
        static void MoveFigure(int figure)
        {
            int figureRow = 0, figureCol = 0, tempDice = diceNumber;
            for (int row = 0, flag = 0; row < 11; row++)
            {
                if (flag == 1) break;
                for (int col = 0; col < 11; col++)
                {
                    if (gameFigures[row, col] == figure)
                    {
                        gameFigures[row, col] = 0;
                        figureRow = row;
                        figureCol = col;
                        flag = 1;
                        break;
                    }
                }
            }
            if (figureRow == 6 && figureCol >= 0 && figureCol <= 3)
            {
                while (figureCol < 4)
                {
                    figureCol++;
                    tempDice--;
                    if (tempDice == 0)
                    {
                        gameFigures[figureRow, figureCol] = figure;
                        return;
                    }
                }
            }
            if (figureCol == 4 && figureRow >= 6 && figureRow <= 9)
            {
                while (figureRow < 10)
                {
                    figureRow++;
                    tempDice--;
                    if (tempDice == 0)
                    {
                        gameFigures[figureRow, figureCol] = figure;
                        return;
                    }
                }
            }
            if (figureRow == 10 && figureCol >= 4 && figureCol <= 5)
            {
                while (figureCol < 6)
                {
                    figureCol++;
                    tempDice--;
                    if (tempDice == 0)
                    {
                        gameFigures[figureRow, figureCol] = figure;
                        return;
                    }
                }
            }
            if (figureCol == 6 && figureRow <= 10 && figureRow >= 7)
            {
                while (figureRow > 6)
                {
                    figureRow--;
                    tempDice--;
                    if (tempDice == 0)
                    {
                        gameFigures[figureRow, figureCol] = figure;
                        return;
                    }
                }
            }
            if (figureRow == 6 && figureCol >= 6 && figureRow <= 9)
            {
                while (figureCol < 10)
                {
                    figureCol++;
                    tempDice--;
                    if (tempDice == 0)
                    {
                        gameFigures[figureRow, figureCol] = figure;
                        return;
                    }
                }
            }
            if (figureCol == 10 && figureRow <= 6 && figureRow >= 5)
            {
                while (figureRow > 4)
                {
                    figureRow--;
                    tempDice--;
                    if (tempDice == 0)
                    {
                        gameFigures[figureRow, figureCol] = figure;
                        return;
                    }
                }
            }
            if (figureRow == 4 && figureCol <= 10 && figureCol >= 7)
            {
                while (figureCol > 6)
                {
                    figureCol--;
                    tempDice--;
                    if (tempDice == 0)
                    {
                        gameFigures[figureRow, figureCol] = figure;
                        return;
                    }
                }
            }
            if (figureCol == 6 && figureRow <= 4 && figureRow >= 1)
            {
                while (figureRow > 0)
                {
                    figureRow--;
                    tempDice--;
                    if (tempDice == 0)
                    {
                        gameFigures[figureRow, figureCol] = figure;
                        return;
                    }
                }
            }
            if (figureRow == 0 && figureCol <= 6 && figureCol >= 5)
            {
                while (figureCol > 4)
                {
                    figureCol--;
                    tempDice--;
                    if (tempDice == 0)
                    {
                        gameFigures[figureRow, figureCol] = figure;
                        return;
                    }
                }
            }
            if (figureCol == 4 && figureRow >= 0 && figureRow <= 3)
            {
                while (figureRow < 4)
                {
                    figureRow++;
                    tempDice--;
                    if (tempDice == 0)
                    {
                        gameFigures[figureRow, figureCol] = figure;
                        return;
                    }
                }
            }
            if (figureRow == 4 && figureCol <= 4 && figureCol >= 1)
            {
                while (figureCol > 0)
                {
                    figureCol--;
                    tempDice--;
                    if (tempDice == 0)
                    {
                        gameFigures[figureRow, figureCol] = figure;
                        return;
                    }
                }
            }
            if (figureCol == 0 && figureRow >= 4 && figureRow <= 5)
            {
                while (figureRow < 5)
                {
                    figureRow++;
                    tempDice--;
                    if (tempDice == 0)
                    {
                        gameFigures[figureRow, figureCol] = figure;
                        return;
                    }
                }
            }
            if (figure >= 10 && figure <= 13 && figureCol == 0 && figureRow == 5)
            {
                while (figureCol < 7)
                {
                    figureCol++;
                    tempDice--;
                    if (tempDice == 0)
                    {
                        gameFigures[figureRow, figureCol] = figure;
                        return;
                    }
                }
            }
            gameFigures[figureRow, figureCol] = figure;
        }
        static void DrawGameFigures()
        {
            for (int row = 0; row < 11; row++)
            {
                for (int col = 0; col < 11; col++)
                {
                    if (gameFigures[row, col] == 0) PrintAtPosition(col * 5 + 2, row * 3 + 1, " ");
                    else if (gameFigures[row, col] == 10) PrintAtPosition(col * 5 + 2, row * 3 + 1, "\u25cb", ConsoleColor.Red);
                    else if (gameFigures[row, col] == 11) PrintAtPosition(col * 5 + 2, row * 3 + 1, "\u25cb", ConsoleColor.Blue);
                    else if (gameFigures[row, col] == 12) PrintAtPosition(col * 5 + 2, row * 3 + 1, "\u25cb", ConsoleColor.Yellow);
                    else if (gameFigures[row, col] == 13) PrintAtPosition(col * 5 + 2, row * 3 + 1, "\u25cb", ConsoleColor.Green);
                    else if (gameFigures[row, col] == 20) PrintAtPosition(col * 5 + 2, row * 3 + 1, "X", ConsoleColor.Red);
                    else if (gameFigures[row, col] == 21) PrintAtPosition(col * 5 + 2, row * 3 + 1, "X", ConsoleColor.Blue);
                    else if (gameFigures[row, col] == 22) PrintAtPosition(col * 5 + 2, row * 3 + 1, "X", ConsoleColor.Yellow);
                    else if (gameFigures[row, col] == 23) PrintAtPosition(col * 5 + 2, row * 3 + 1, "X", ConsoleColor.Green);
                    else if (gameFigures[row, col] == 30) PrintAtPosition(col * 5 + 2, row * 3 + 1, "\u25cb", ConsoleColor.Red);
                    else if (gameFigures[row, col] == 31) PrintAtPosition(col * 5 + 2, row * 3 + 1, "\u25cb", ConsoleColor.Blue);
                    else if (gameFigures[row, col] == 32) PrintAtPosition(col * 5 + 2, row * 3 + 1, "\u25cb", ConsoleColor.Yellow);
                    else if (gameFigures[row, col] == 33) PrintAtPosition(col * 5 + 2, row * 3 + 1, "\u25cb", ConsoleColor.Green);
                    else if (gameFigures[row, col] == 40) PrintAtPosition(col * 5 + 2, row * 3 + 1, "\u25b2", ConsoleColor.Red);
                    else if (gameFigures[row, col] == 41) PrintAtPosition(col * 5 + 2, row * 3 + 1, "\u25b2", ConsoleColor.Blue);
                    else if (gameFigures[row, col] == 42) PrintAtPosition(col * 5 + 2, row * 3 + 1, "\u25b2", ConsoleColor.Yellow);
                    else if (gameFigures[row, col] == 43) PrintAtPosition(col * 5 + 2, row * 3 + 1, "\u25b2", ConsoleColor.Green);
                }
            }
        }
        static void ActionAfterRoll()
        {
            byte y = 5;
            int[] tempArray = new int[4];
            PrintAtPosition(56, y++, "Select action:");
            switch (currentPlayer)
            {
                case 1: tempArray = player1Figures; break;
                case 2: tempArray = player2Figures; break;
                case 3: tempArray = player3Figures; break;
                case 4: tempArray = player4Figures; break;
            }
            if (tempArray[0] == 0) PrintAtPosition(56, y++, "1.  Move red figure", ConsoleColor.White, ConsoleColor.Red);
            if (tempArray[1] == 0) PrintAtPosition(56, y++, "2.  Move blue figure", ConsoleColor.White, ConsoleColor.Blue);
            if (tempArray[2] == 0) PrintAtPosition(56, y++, "3.  Move yellow figure", ConsoleColor.White, ConsoleColor.Yellow);
            if (tempArray[3] == 0) PrintAtPosition(56, y++, "4.  Move green figure", ConsoleColor.White, ConsoleColor.Green);
            if (diceNumber == 6 && (tempArray[0] == 1 || tempArray[1] == 1 || tempArray[2] == 1 || tempArray[3] == 1)) PrintAtPosition(56, y++, "5.  Get new figure");
            while (tempArray[0] == 0 || tempArray[1] == 0 || tempArray[2] == 0 || tempArray[3] == 0 || diceNumber == 6)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.D1 && tempArray[0] == 0)
                {
                    MoveFigure(currentPlayer * 10);
                    return;
                }
                if (pressedKey.Key == ConsoleKey.D2 && tempArray[1] == 0)
                {
                    MoveFigure(currentPlayer * 10 + 1);
                    return;
                }
                if (pressedKey.Key == ConsoleKey.D3 && tempArray[2] == 0)
                {
                    MoveFigure(currentPlayer * 10 + 2);
                    return;
                }
                if (pressedKey.Key == ConsoleKey.D4 && tempArray[3] == 0)
                {
                    MoveFigure(currentPlayer * 10 + 3);
                    return;
                }
                if (pressedKey.Key == ConsoleKey.D5 && diceNumber == 6 && (tempArray[0] == 1 || tempArray[1] == 1 || tempArray[2] == 1 || tempArray[3] == 1))
                {
                    GetNewFigure(tempArray, currentPlayer);
                    return;
                }
            }
        }
        static void GetNewFigure(int[] array, int currentPlayer)
        {
            for (int i = 0; i < 4; i++)
            {
                if (array[i] == 1)
                {
                    array[i] = 0;
                    if (currentPlayer == 1)
                    {
                        switch (i)
                        {
                            case 0: gameFigures[8, 1] = 0; gameFigures[6, 0] = 10; break;
                            case 1: gameFigures[8, 2] = 0; gameFigures[6, 0] = 11; break;
                            case 2: gameFigures[9, 1] = 0; gameFigures[6, 0] = 12; break;
                            case 3: gameFigures[9, 2] = 0; gameFigures[6, 0] = 13; break;
                        }
                    }
                    else if (currentPlayer == 2)
                    {
                        switch (i)
                        {
                            case 0: gameFigures[8, 8] = 0; gameFigures[10, 6] = 20; break;
                            case 1: gameFigures[8, 9] = 0; gameFigures[10, 6] = 21; break;
                            case 2: gameFigures[9, 8] = 0; gameFigures[10, 6] = 22; break;
                            case 3: gameFigures[9, 9] = 0; gameFigures[10, 6] = 23; break;

                        }
                    }
                    else if (currentPlayer == 3)
                    {
                        switch (i)
                        {
                            case 0: gameFigures[1, 8] = 0; gameFigures[4, 10] = 30; break;
                            case 1: gameFigures[1, 9] = 0; gameFigures[4, 10] = 31; break;
                            case 2: gameFigures[2, 8] = 0; gameFigures[4, 10] = 32; break;
                            case 3: gameFigures[2, 9] = 0; gameFigures[4, 10] = 33; break;
                        }
                    }
                    else
                    {
                        switch (i)
                        {
                            case 0: gameFigures[1, 1] = 0; gameFigures[0, 4] = 40; break;
                            case 1: gameFigures[1, 2] = 0; gameFigures[0, 4] = 41; break;
                            case 2: gameFigures[2, 1] = 0; gameFigures[0, 4] = 42; break;
                            case 3: gameFigures[2, 2] = 0; gameFigures[0, 4] = 43; break;
                        }
                    }
                    return;
                }
            }
        }
        static void ClearConsoleArea(int length, int x, int y)
        {
            for (int i = y; i < y + length; i++)
            {
                Console.SetCursorPosition(x, i);
                PrintAtPosition(x, i, "                                          ");
            }
        }
        static void WaitForKey(ConsoleKey keyName)
        {
            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == keyName) break;
            }
        }
        static void DrawGameField()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WindowHeight = 34;
            Console.WindowWidth = 100;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            DrawHorizontalSquareLine(5, 0, 12);
            DrawHorizontalSquareLine(1, 0, 15);
            DrawHorizontalSquareLine(4, 5, 15, ConsoleColor.Red);
            DrawHorizontalSquareLine(1, 0, 18, ConsoleColor.Red);
            DrawHorizontalSquareLine(4, 5, 18);
            DrawVerticalSquareLine(1, 20, 0, ConsoleColor.Green);
            DrawVerticalSquareLine(1, 25, 0);
            DrawVerticalSquareLine(4, 25, 3, ConsoleColor.Green);
            DrawVerticalSquareLine(4, 20, 3);
            DrawVerticalSquareLine(5, 30, 0);
            DrawVerticalSquareLine(4, 20, 21);
            DrawVerticalSquareLine(1, 25, 30);
            DrawVerticalSquareLine(4, 25, 18, ConsoleColor.Blue);
            DrawVerticalSquareLine(1, 30, 30, ConsoleColor.Blue);
            DrawVerticalSquareLine(4, 30, 18);
            DrawHorizontalSquareLine(3, 35, 12);
            DrawHorizontalSquareLine(1, 50, 12, ConsoleColor.Yellow);
            DrawHorizontalSquareLine(4, 30, 15, ConsoleColor.Yellow);
            DrawHorizontalSquareLine(4, 35, 18);
            DrawHorizontalSquareLine(1, 50, 15);
            DrawHorizontalSquareLine(2, 5, 3, ConsoleColor.Green);
            DrawHorizontalSquareLine(2, 5, 6, ConsoleColor.Green);
            DrawHorizontalSquareLine(2, 40, 3, ConsoleColor.Yellow);
            DrawHorizontalSquareLine(2, 40, 6, ConsoleColor.Yellow);
            DrawHorizontalSquareLine(2, 5, 24, ConsoleColor.Red);
            DrawHorizontalSquareLine(2, 5, 27, ConsoleColor.Red);
            DrawHorizontalSquareLine(2, 40, 24, ConsoleColor.Blue);
            DrawHorizontalSquareLine(2, 40, 27, ConsoleColor.Blue);
        }
        static void DrawHorizontalSquareLine(int lenght, int x, int y, ConsoleColor color = ConsoleColor.White)
        {
            for (int i = 0; i < lenght; i++)
            {
                Console.BackgroundColor = color;
                Console.SetCursorPosition(x + i * 5, y);
                Console.WriteLine("|\u0305\u0305\u0305|");
                Console.SetCursorPosition(x + i * 5, y + 1);
                Console.WriteLine("|   |");
                Console.SetCursorPosition(x + i * 5, y + 2);
                Console.WriteLine("|___|");
            }
        }
        static void DrawVerticalSquareLine(int lenght, int x, int y, ConsoleColor color = ConsoleColor.White)
        {
            for (int i = 0; i < lenght; i++)
            {
                Console.BackgroundColor = color;
                Console.SetCursorPosition(x, y + i * 3);
                Console.WriteLine("|\u0305\u0305\u0305|");
                Console.SetCursorPosition(x, y + i * 3 + 1);
                Console.WriteLine("|   |");
                Console.SetCursorPosition(x, y + i * 3 + 2);
                Console.WriteLine("|___|");
            }
        }
        static void PrintAtPosition(int x, int y, string text, ConsoleColor backgroundColor = ConsoleColor.White, ConsoleColor foregroundColor = ConsoleColor.Black)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.SetCursorPosition(x, y);
            Console.Write(text);
        }
    }
}