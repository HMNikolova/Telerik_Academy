﻿namespace Cube2
{
    using System;
    using System.Text;

    class Solution
    {
        const char Blank = ' ';
        const char FrontFill = ' ';
        const char BotFill = '-';
        const char SideFill = '|';
        const char SideDot = ':';

        //const int size = 5;

        static void Main()
        {
            //new TestsGenerator().GenerateTests();

            int size = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int fieldSize = 2 * size - 1;
            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    if (row == 0 && col <= size - 1 ||
                        row == size - 1 && col <= size - 1 ||
                        row == fieldSize - 1 && col >= size - 1)
                    { // horizontal lines
                        sb.Append(SideDot);
                    }
                    else if (col == 0 && row <= size - 1 ||
                        col == size - 1 && row <= size - 1 ||
                        col == fieldSize - 1 && row >= size - 1)
                    { // vertical lines
                        sb.Append(SideDot);
                    }
                    else if (row - col == 0 && row >= size - 1 ||
                        row - col == size - 1 ||
                        col - row == size - 1)
                    { // oblique lines
                        sb.Append(SideDot);
                    }
                    else if (row - col < size - 1 &&
                        row - col > 0 &&
                        row > size - 1)
                    { // bottom fill
                        sb.Append(BotFill);
                    }
                    else if (col - row < size - 1 &&
                        row - col < 0 &&
                        col > size - 1)
                    { // side fill
                        sb.Append(SideFill);
                    }
                    else
                    {
                        sb.Append(Blank);
                    }
                }

                if (row != fieldSize - 1)
                {
                    sb.AppendLine();
                }
            }

            Console.WriteLine(sb);
        }
    }
}
