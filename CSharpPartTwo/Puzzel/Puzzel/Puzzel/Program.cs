﻿using System;
using System.Threading;
using System.Linq;
using System.IO;

namespace OrderNumberGame
{
    class Puzzel
    {
        const int MaxHeight = 40;
        const int MaxWidth = 70;
        static int selectorIndexRow = 0;
        static int selectorIndexCol = 0;
        static DateTime startTime;
        static bool loadSavedGame = false;
        static string fileName = @"Save.txt"; // Here is file where the game is saved and load
        static string timerFileName = @"Timer.txt";
        static int matrixDimension = 4;
        static int[,] matrix;
        static int gameTimeOutInMinutes = 10;
        static TimeSpan maxTime;
        static TimeSpan remainingTime;
        static int percentageOfOrderedElemnts = 0;

        static void Main()
        {
            while (true)
            {
                Settings();

                Console.BufferHeight = Console.WindowHeight = MaxHeight;
                Console.BufferWidth = Console.WindowWidth = MaxWidth;

                Menu();
                HelpMenu();

                if (loadSavedGame == false)
                {
                    matrix = InicializeMatrix(matrixDimension);
                    maxTime = TimeSpan.FromMinutes(gameTimeOutInMinutes);
                    remainingTime = maxTime;
                }
                else
                {
                    matrix = Load(fileName);
                    int[] savedRemainingTime = LoadTimer(timerFileName);
                    maxTime = TimeSpan.FromMinutes(savedRemainingTime[0]) + TimeSpan.FromSeconds(savedRemainingTime[1]);
                    remainingTime = maxTime;
                }

                startTime = DateTime.Now;

                bool endOfGame = true;
                while ((remainingTime.Minutes >= 0 && remainingTime.Seconds >= 0 && percentageOfOrderedElemnts < 100))
                {
                    percentageOfOrderedElemnts = CheckOrderedElementsPercentage(matrix);
                    PrintMatrix(matrixDimension, matrix, Console.WindowWidth / 2 - 25, Console.WindowHeight / 2);
                    remainingTime = CalculateRemainingTime(maxTime);

                    PrintTimer(remainingTime, Console.WindowWidth - 26, Console.WindowHeight - 30);
                    PrintPercentageOfOrderedElements(percentageOfOrderedElemnts, Console.WindowWidth - 26, Console.WindowHeight - 32);

                    try
                    {
                        ConsoleKeyInfo pressedKeys = default(ConsoleKeyInfo);
                        if (Console.KeyAvailable)
                        {
                            pressedKeys = Console.ReadKey();
                            if (pressedKeys.Key == ConsoleKey.Spacebar)
                            {
                                MoveAntyClockWiseNumbersOrderInSelector(matrix);
                            }
                            else if (pressedKeys.Key == ConsoleKey.RightArrow)
                            {
                                SelectorMove("right", matrixDimension);
                            }
                            else if (pressedKeys.Key == ConsoleKey.LeftArrow)
                            {
                                SelectorMove("left", matrixDimension);
                            }
                            else if (pressedKeys.Key == ConsoleKey.UpArrow)
                            {
                                SelectorMove("up", matrixDimension);
                            }
                            else if (pressedKeys.Key == ConsoleKey.DownArrow)
                            {
                                SelectorMove("down", matrixDimension);
                            }
                            else if (pressedKeys.Key == ConsoleKey.S)
                            {
                                Save(matrix, fileName);
                                SaveTimer(remainingTime, timerFileName);
                                endOfGame = false;
                                Console.Clear();
                                break;
                            }

                            else if (pressedKeys.Key == ConsoleKey.D)
                            {
                                Console.Clear();
                                HelpMenu();
                                PrintHelpMenu();
                            }
                            else if (pressedKeys.Key == ConsoleKey.H)
                            {
                                PrintHelpMenu();
                                Console.Clear();
                                HelpMenu();
                            }
                            else
                            {
                                throw new InvalidOperationException();
                            }
                        }
                    }
                    catch (InvalidOperationException)
                    {
                        Console.Clear();
                        HelpMenu();
                        continue;
                    }
                }

                Console.Clear();

                if (percentageOfOrderedElemnts == 100)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(30, Console.WindowHeight / 2 - 6);
                    Console.WriteLine("YOU WIN!!!");
                    Console.SetCursorPosition(13, Console.WindowHeight / 2 - 4);
                    Console.WriteLine("The puzel is {0}% ordered for {1} minutes!",
                        percentageOfOrderedElemnts, CalculateTimeFromStart(maxTime, remainingTime));
                    Console.SetCursorPosition(8, Console.WindowHeight / 2 + 10);
                    break;
                }
                else if (endOfGame == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(30, Console.WindowHeight / 2 - 6);
                    Console.WriteLine("GAME OVER!!!");
                    Console.SetCursorPosition(13, Console.WindowHeight / 2 - 4);
                    Console.WriteLine("The puzel is {0}% ordered for {1} minutes!",
                        percentageOfOrderedElemnts, CalculateTimeFromStart(maxTime, remainingTime));
                    Console.SetCursorPosition(8, Console.WindowHeight / 2 + 10);
                }
                else
                {
                    Console.SetCursorPosition(Console.BufferWidth / 2 - 6, Console.WindowHeight / 2 - 6);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Game saved");
                }
            }
        }

        static void Settings() // global environment settings
        {
            Console.Title = "..::: OrderNumberGame :::.."; // game name in console bar
            Console.CursorVisible = false; // cursur deactivated
        }

        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2 - 3);
            Console.WriteLine("..::: ORDER NUMBER GAME :::..");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 1);
            Console.WriteLine("Commands:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 16, Console.WindowHeight / 2);
            Console.WriteLine("to START new game - type \"start\"");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 + 1);
            Console.WriteLine("to LOAD saved game - type \"load\"");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 12, Console.WindowHeight / 2 + 2);
            Console.WriteLine("for EXIT - type \"exit\"");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2 + 3);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Enter command here:");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 3, Console.WindowHeight / 2 + 4);
            string command = Console.ReadLine();

            try
            {
                if ((command != "start") && (command != "load") && (command != "exit"))
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(Console.WindowWidth / 2 - 13, Console.WindowHeight / 2 + 7);
                Console.WriteLine("Invalid command! Try again!");
                Thread.Sleep(800);
                Console.Clear();
                Menu();
            }

            if (command == "exit")
            {
                Environment.Exit(0);
            }
            else if (command == "load")
            {
                Settings();
                Console.Clear();
                loadSavedGame = true;
            }

            Console.Clear();
        }

        static void HelpMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2);
            Console.WriteLine("to SHOW Help menu press \"D\"");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2 + 1);
            Console.WriteLine("to HIDE Help Menu press \"H\"");
        }

        static void PrintHelpMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2 + 3);
            Console.WriteLine("To MOVE press ARROW keys");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2 + 4);
            Console.WriteLine("To ROTATE numbers press SPACE BAR");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2 + 5);
            Console.WriteLine("To SAVE and exit game press \"S\"");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2 + 6);
            Console.WriteLine("GAMEPLAY: The main objective of the");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2 + 7);
            Console.WriteLine("game is to arrange the numbers in");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2 + 8);
            Console.WriteLine("sequence from top to bottom,");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight / 2 + 9);
            Console.WriteLine("before the time is out!");
        }

        static void Save(int[,] testValues, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);

            writer.WriteLine(testValues.GetLength(0));
            writer.WriteLine(testValues.GetLength(1));

            for (int i = 0; i < testValues.GetLength(0); i++)
            {
                for (int j = 0; j < testValues.GetLength(1); j++)
                {
                    writer.WriteLine(testValues[i, j]);
                }
            }
            writer.Close();
        }

        static void SaveTimer(TimeSpan remeiningTimeTS, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(remeiningTimeTS.Minutes.ToString());
            writer.WriteLine(remeiningTimeTS.Seconds.ToString());
            writer.Close();
        }

        static int[,] Load(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            int width;
            int height;
            //reads the first value in the text file. It is the width of the matrix
            int.TryParse(reader.ReadLine(), out width);
            //reads the second value in the text file. It is the hight of the matrix
            int.TryParse(reader.ReadLine(), out height);
            int[,] readValues = new int[width, height];

            for (int i = 0; i < readValues.GetLength(0); i++)
            {
                for (int j = 0; j < readValues.GetLength(1); j++)
                {
                    int.TryParse(reader.ReadLine(), out readValues[i, j]);
                }
            }
            reader.Close();
            return readValues;

        }

        static int[] LoadTimer(string timerFileName)
        {
            StreamReader reader = new StreamReader(timerFileName);
            int[] savedRemainingTime = new int[2];
            int.TryParse(reader.ReadLine(), out savedRemainingTime[0]);
            int.TryParse(reader.ReadLine(), out savedRemainingTime[1]);
            reader.Close();
            return savedRemainingTime;
        }

        private static int CheckOrderedElementsPercentage(int[,] matrix)
        {
            int matrixDimention = matrix.GetLength(0);
            int currentOrderedElement = 0;
            int countOrderedElements = 0;
            for (int row = 0; row < matrixDimention; row++)
            {
                for (int col = 0; col < matrixDimention; col++)
                {
                    currentOrderedElement++;
                    if (matrix[row, col] == currentOrderedElement)
                    {
                        countOrderedElements++;
                    }
                }
            }
            int orderedElementPercetage = (countOrderedElements * 100) / (int)Math.Pow(matrixDimention, 2);
            return orderedElementPercetage;
        }

        private static void PrintPercentageOfOrderedElements(int percentageOfOrderedElemnts,
            int coordinateX, int coordinateY)
        {
            Console.SetCursorPosition(coordinateX, coordinateY);
            Console.WriteLine("Ordered: {0}%", percentageOfOrderedElemnts);
        }

        private static void PrintTimer(TimeSpan remeiningTimeTS, int coordinateX, int coordinateY)
        {
            Console.SetCursorPosition(coordinateX, coordinateY);
            Console.WriteLine("Time left:");
            Console.SetCursorPosition(coordinateX + 3, coordinateY + 2);
            if (remeiningTimeTS.Minutes == 0 && remeiningTimeTS.Seconds == -1)
            {
                Console.WriteLine("00:00");
            }
            else
            {
                Console.WriteLine("{0,2:00}:{1,2:00}", remeiningTimeTS.Minutes, remeiningTimeTS.Seconds);
            }
        }

        private static TimeSpan CalculateRemainingTime(TimeSpan maxTime)
        {
            TimeSpan remeiningTimeTS = maxTime - (DateTime.Now - startTime);
            return remeiningTimeTS;
        }

        private static string CalculateTimeFromStart(TimeSpan maxTime, TimeSpan remeiningTimeTS)
        {
            TimeSpan spentTime = maxTime - remeiningTimeTS - TimeSpan.FromSeconds(1);

            string elapsedTime = string.Format("{0,2:00}:{1,2:00}", spentTime.Minutes, spentTime.Seconds);
            return elapsedTime;
        }

        private static void MoveAntyClockWiseNumbersOrderInSelector(int[,] matrix)
        {
            int temp = matrix[selectorIndexRow, selectorIndexCol];
            int temp2 = matrix[selectorIndexRow + 1, selectorIndexCol];
            int temp3 = matrix[selectorIndexRow + 1, selectorIndexCol + 1];
            int temp4 = matrix[selectorIndexRow, selectorIndexCol + 1];

            matrix[selectorIndexRow, selectorIndexCol] = temp4;
            matrix[selectorIndexRow + 1, selectorIndexCol] = temp;
            matrix[selectorIndexRow + 1, selectorIndexCol + 1] = temp2;
            matrix[selectorIndexRow, selectorIndexCol + 1] = temp3;
        }

        private static void SelectorMove(string direction, int matrixDimention)
        {
            if (direction.CompareTo("right") == 0)
            {
                if (selectorIndexCol < matrixDimention - 2)
                {
                    selectorIndexCol += 1;
                }

            }
            else if (direction.CompareTo("left") == 0)
            {
                if (selectorIndexCol >= 1)
                {
                    selectorIndexCol -= 1;
                }
            }
            else if (direction.CompareTo("up") == 0)
            {
                if (selectorIndexRow >= 1)
                {
                    selectorIndexRow -= 1;
                }
            }
            else if (direction.CompareTo("down") == 0)
            {
                if (selectorIndexRow < matrixDimention - 2)
                {
                    selectorIndexRow += 1;
                }
            }

        }

        private static int[,] InicializeMatrix(int matrixDimension)
        {
            Random rand = new Random();
            int[] myArray = new int[matrixDimension * matrixDimension];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i + 1;
            }

            myArray = myArray.OrderBy(x => rand.Next()).ToArray();
            int count = 0;

            int[,] matrix = new int[matrixDimension, matrixDimension];
            for (int j = 0; j < matrixDimension; j++)
            {
                for (int k = 0; k < matrixDimension; k++)
                {
                    matrix[j, k] = myArray[count];
                    count++;
                }
            }
            return matrix;
        }

        private static void PrintMatrix(int matrixDimension, int[,] matrix, int coordinateX, int coordinateY)
        {
            for (int row = 0; row < matrixDimension; row++)
            {
                Console.SetCursorPosition(coordinateX, coordinateY - 5 + row * 2);
                for (int col = 0; col < matrixDimension; col++)
                {
                    if (row >= selectorIndexRow && row <= (selectorIndexRow + 1) && col >= selectorIndexCol && col <= (selectorIndexCol + 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}