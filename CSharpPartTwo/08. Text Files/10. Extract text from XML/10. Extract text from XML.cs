﻿using System;
using System.IO;
using System.Text;

class ExtractTextFromXML
{
        //•	Write a program that extracts from given XML file all the text without the tags.
        static bool tagOpened;

    static void Main()
    {
        if (File.Exists(@"..\..\output.txt"))
        {
            File.Delete(@"..\..\output.txt");
        }

        using (StreamReader source = new StreamReader(@"..\..\source.txt"))
        {
            using (StreamWriter output = new StreamWriter(@"..\..\output.txt", true))
            {
                string sourceLine = source.ReadLine();

                while (sourceLine != null)
                {
                    // remove all tags
                    sourceLine = RemoveTags(sourceLine);
                    // remove extra spaces
                    sourceLine = RemoveSpaces(sourceLine);

                    if (sourceLine != "")   // if there is text left in current read line write it to output.txt
                    {
                        output.WriteLine(sourceLine);
                    }

                    sourceLine = source.ReadLine();
                }
            }
        }
    }

    static string RemoveTags(string input)
    {
        StringBuilder sbIn = new StringBuilder();
        StringBuilder sbOut = new StringBuilder();
        sbIn.Append(input);
        while (sbIn.ToString().Contains("<") || sbIn.ToString().Contains(">"))
        {
            int start = sbIn.ToString().IndexOf("<");
            int end = sbIn.ToString().IndexOf(">");

            if (start >= 0 && end >= 0)
            {
                sbIn.Remove(start, end - start + 1);
                sbIn.Insert(start, " ");
            }

            else if (start >= 0 && end < 0)
            {
                sbIn.Remove(start, sbIn.Length - start);
                //sbIn.Insert(start, " ");
                tagOpened = true;
            }

            else if (start < 0 && end >= 0)
            {
                sbIn.Remove(0, end + 1);
                tagOpened = false;
            }

            else if (start < 0 && end < 0 && tagOpened)
            {
                sbIn.Clear();
                sbIn.Append("");
            }
        }

        return sbIn.ToString();
    }

    static string RemoveSpaces(string input)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(input);

        for (int i = 0; i < sb.Length-1; i++)
        {
            if (sb[i]==' ' && sb[i+1]==' ')
            {
                sb.Remove(i + 1, 1);
                i--;
            }
        }

        return sb.ToString().Trim();
    }
    }


