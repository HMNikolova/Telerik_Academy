﻿using System;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        //•	Write a program that deletes from given text file all odd lines.
        //•	The result should be in the same file.
        if (File.Exists(@"..\..\temp.txt"))
        {
            File.Delete(@"..\..\temp.txt");
        }

        using (StreamReader source = new StreamReader(@"..\..\source.txt"))
        {
            using (StreamWriter output = new StreamWriter(@"..\..\temp.txt", true))
            {
                string sourceLine = source.ReadLine();
                int i = 1;
                while (sourceLine != null)
                {
                    if (i % 2 == 0)
                    {
                        output.WriteLine(sourceLine);
                    }

                    i++;
                    sourceLine = source.ReadLine();
                }
            }
        }

        File.Copy(@"..\..\temp.txt", @"..\..\source.txt", true);
        File.Delete(@"..\..\temp.txt");
    }
}

