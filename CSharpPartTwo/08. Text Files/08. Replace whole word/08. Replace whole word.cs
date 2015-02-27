﻿using System;
using System.Collections.Generic;
using System.IO;

class ReplaceWholeWord
{
    static void Main()
    {
        //•	Modify the solution of the previous problem to replace only whole words (not strings).
        List<char> punctuationAndDelimiters = new List<char>();
        for (int i = 0; i < 128; i++)
        {
            if (Char.IsPunctuation((char)i) || Char.IsSeparator((char)i))
            {
                punctuationAndDelimiters.Add((char)i);
            }
        }
        char[] punctuation = new char[punctuationAndDelimiters.Count];
        for (int i = 0; i < punctuationAndDelimiters.Count; i++)
        {
            punctuation[i] = punctuationAndDelimiters[i];
        }

        using (StreamReader source = new StreamReader(@"..\..\source.txt"))
        {
            string sourceLine = source.ReadLine();
            using (StreamWriter output = new StreamWriter(@"..\..\output.txt"))
            {
                while (sourceLine != null)
                {
                    string[] wordsArray = sourceLine.Split(' ');

                    for (int i = 0; i < wordsArray.Length; i++)
                    {
                        string[] word = wordsArray[i].Split(punctuation, StringSplitOptions.RemoveEmptyEntries);
                        if (word.Length == 1)
                        {
                            if (word[0] == "start")
                            {
                                wordsArray[i] = wordsArray[i].Replace("start", "finish");
                            }
                        }
                    }
                    sourceLine = "";
                    for (int i = 0; i < wordsArray.Length; i++)
                    {
                        if (i == 0)
                        {
                            sourceLine += wordsArray[i];
                        }

                        else
                        {
                            sourceLine += (" " + wordsArray[i]);
                        }

                    }
                    output.WriteLine(sourceLine);
                    sourceLine = source.ReadLine();
                }

            }
        }
    }
}

