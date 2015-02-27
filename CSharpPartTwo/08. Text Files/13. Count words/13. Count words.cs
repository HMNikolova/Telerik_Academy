﻿using System;
using System.Collections.Generic;
using System.IO;

class CountWords
{
    static void Main()
    {
        /*•	Write a program that reads a list of words from the file words.txt and finds how
         *  many times each of the words is contained in another file test.txt.
          •	The result should be written in the file result.txt and the words should be 
         *  sorted by the number of their occurrences in descending order.
          •	Handle all possible exceptions in your methods.*/
        string[] filther = LoadFiltherWords();  // holds the words
        int[] filtherCount = new int[filther.Length];   // holds the count of each word with corresponding index

        using (StreamReader source = new StreamReader(@"..\..\source.txt"))
        {
            string sourceLine = source.ReadLine();

            while (sourceLine != null)
            {
                string[] words = sourceLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                sourceLine = "";

                for (int i = 0; i < words.Length; i++)
                {
                    if (IsWord(words[i]))
                    {
                        for (int j = 0; j < filther.Length; j++)
                        {
                            if (RemovePunctuation(words[i]).ToLower() == filther[j].ToLower())
                            {
                                filtherCount[j]++;
                            }
                        }
                    }
                }

                sourceLine = source.ReadLine();
            }

            // unite words count and words string values in one array of strings beginning with count
            string[] result = new string[filther.Length];
            for (int i = 0; i < filther.Length; i++)
            {
                result[i] = filtherCount[i].ToString() + " " + filther[i];
            }

            Array.Sort(result);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }

    static char[] WordSymbolsArr()
    {
        char[] letters = new char[63];
        for (int i = 0; i < 10; i++)
        {
            letters[i] = (char)(48 + i);
        }

        int asciiIndex = 0;
        for (int i = 0; i < 52; i += 2)
        {
            letters[10 + i] = (char)(65 + asciiIndex);
            letters[10 + i + 1] = (char)(97 + asciiIndex);
            asciiIndex++;
        }

        letters[62] = '_';

        return letters;
    }

    static char[] PunctuationArr()
    {
        List<char> punctuationList = new List<char>();
        for (int i = 0; i < 128; i++)
        {
            if (Char.IsPunctuation((char)i)) //|| Char.IsSeparator((char)i))
            {
                punctuationList.Add((char)i);
            }
        }

        punctuationList.Remove('_');

        char[] punctuation = new char[punctuationList.Count];
        for (int i = 0; i < punctuationList.Count; i++)
        {
            punctuation[i] = punctuationList[i];
        }

        return punctuation;
    }

    static bool IsWord(string word)
    {
        string input = word;
        char[] wordSymbols = WordSymbolsArr();
        bool isWord;
        if (input == "" || input == null)
        {
            return false;
        }

        input = RemovePunctuation(input);

        string[] removedWordSymbols = input.Split(wordSymbols, StringSplitOptions.RemoveEmptyEntries);

        if (removedWordSymbols.Length == 0)
        {
            isWord = true;
        }

        else
        {
            isWord = false;
        }

        return isWord;
    }

    static string RemovePunctuation(string word)
    {
        string input = word;
        char[] punctuation = PunctuationArr();

        input = input.Trim(punctuation);

        //if (input == "")
        //{
        //    return input;
        //}

        //for (int i = 0; i < punctuation.Length; i++)
        //{
        //    if (input[0] == punctuation[i])
        //    {
        //        input = input.Remove(0, 1);
        //        break;
        //    }
        //}

        //if (input == "")
        //{
        //    return input;
        //}

        //for (int i = 0; i < punctuation.Length; i++)
        //{
        //    if (input[input.Length - 1] == punctuation[i])
        //    {
        //        input = input.Remove(input.Length - 1, 1);
        //        break;
        //    }
        //}

        return input;
    }

    static string[] LoadFiltherWords()
    {
        List<string> filtherWords = new List<string>();
        using (StreamReader source = new StreamReader(@"..\..\filther.txt"))
        {
            string currentLine = source.ReadLine();
            while (currentLine != null)
            {
                if (!IsWord(currentLine))
                {
                    throw new Exception("Invalid filther word found! Possible empty line in filther words source file or invalid character in word.");
                }

                filtherWords.Add(currentLine);
                currentLine = source.ReadLine();
            }
        }

        return filtherWords.ToArray();
    }
}

