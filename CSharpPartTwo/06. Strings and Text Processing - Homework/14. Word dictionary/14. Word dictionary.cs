using System;

class WordDictionary
{
    static void Main()
    {
        /*•	A dictionary is stored as a sequence of text lines containing words and 
         * their explanations.
          •	Write a program that enters a word and translates it by using the dictionary.*/
        string text = ".NET - platform for applications from Microsoft\nCLR - managed execution environment for .NET\nnamespace - hierarchical organization of classes";

        string[] textWords = text.Split(new char[] { '\n', '-' });

        string input = Console.ReadLine();
        string searchedWord = input + " ";

        for (int i = 0; i < textWords.Length; i++)
        {
            if (string.Compare(searchedWord, textWords[i], true) == 0)
            {
                Console.WriteLine(input + " -" + textWords[i + 1].ToString());
            }
        }
    }
}
