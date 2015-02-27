﻿using System;
using System.Collections.Generic;
using System.IO;

class PrefixTest
{
    static void Main()
    {
        //•	Write a program that deletes from a text file all words that start with the prefix test.
        //•	Words contain only the symbols 0…9, a…z, A…Z, _.
        char[] letters = WordSymbolsArr();

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
                    string[] words = sourceLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    sourceLine = "";

                    for (int i = 0; i < words.Length; i++)
                    {
                        if (IsWord(words[i]))
                        {
                            if (RemovePunctuation(words[i]).IndexOf("test") == 0)
                            {
                                words[i] = "";
                            }
                        }

                        if (i != 0)
                        {
                            sourceLine += " " + words[i];
                        }

                        else
                        {
                            sourceLine += words[i];
                        }
                    }

                    output.WriteLine(sourceLine);
                    sourceLine = source.ReadLine();
                }
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
            if (Char.IsPunctuation((char)i)) 
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
    static bool IsWord(string input)
    {
        char[] wordSymbols = WordSymbolsArr();
        bool isWord;
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
    static string RemovePunctuation(string input)
    {
        char[] punctuation = PunctuationArr();
        for (int i = 0; i < punctuation.Length; i++)
        {
            if (input[0] == punctuation[i])
            {
                input = input.Remove(0, 1);
                break;
            }
        }
        for (int i = 0; i < punctuation.Length; i++)
        {
            if (input[input.Length - 1] == punctuation[i])
            {
                input = input.Remove(input.Length - 1, 1);
                break;
            }
        }

        return input;
    }
}

