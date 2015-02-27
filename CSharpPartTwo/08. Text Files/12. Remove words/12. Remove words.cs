﻿using System;
using System.IO;
using System.Collections.Generic;

class RemoveWords
{
    static void Main()
    {
        //•	Write a program that removes from a text file all words listed in given another text file.
        //•	Handle all possible exceptions in your methods.
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
                            words[i] = FiltherWords(words[i]);
                        }

                        if (i != 0)
                        {
                            if (RemovePunctuation(words[i]) != "" && words[i - 1] != null)
                            {
                                sourceLine += " " + words[i];
                            }

                            else
                            {
                                sourceLine += words[i];
                            }
                        }

                        else
                        {
                            if (RemovePunctuation(words[i]) != "")
                            {
                                sourceLine += words[i];
                            }

                            else
                            {
                                words[i] = null;
                            }
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

        if (input == "")
        {
            return input;
        }

        for (int i = 0; i < punctuation.Length; i++)
        {
            if (input[0] == punctuation[i])
            {
                input = input.Remove(0, 1);
                break;
            }
        }

        if (input == "")
        {
            return input;
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
    static string FiltherWords(string word)
    {
        string input = word;
        string[] filther = LoadFiltherWords();

        for (int i = 0; i < filther.Length; i++)
        {
            if (RemovePunctuation(input).ToLower() == filther[i].ToLower())
            {
                input = input.ToLower();
                input = input.Replace(filther[i].ToLower(), "");

                if (RemovePunctuation(input) == "")
                {
                    break;
                }
            }
        }

        return input;
    }
}

