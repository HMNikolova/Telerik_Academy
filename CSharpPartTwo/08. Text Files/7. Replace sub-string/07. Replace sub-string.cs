﻿using System;
using System.IO;

class ReplaceSubString
{
    static void Main()
    {
        /*•	Write a program that replaces all occurrences of the sub-string start with 
         *  the sub-string finish in a text file.
          •	Ensure it will work with large files (e.g. 100 MB).*/
        using (StreamReader source = new StreamReader(@"..\..\source.txt"))
        {
            string sourceLine = source.ReadLine();
            using (StreamWriter output = new StreamWriter(@"..\..\output.txt"))
            {
                while (sourceLine != null)
                {
                    sourceLine = sourceLine.Replace("start", "finish");
                    output.WriteLine(sourceLine);
                    sourceLine = source.ReadLine();
                }

            }
        }
    }
}

