//12. Index of letters
//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Collections.Generic;
using System.Linq;

    class IndexOfLetters
    {
        static void Main()
        {
            int[] letters = new int[26];
            for (char i = 'A'; i <= 'Z'; i++) 
                letters[i - 65] = i;

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            foreach (char n in word)
            {
                Console.WriteLine("Letter '{0}' -> index: {1} / ASCII index: {2}",
                    n, Array.IndexOf(letters, char.ToUpperInvariant(n)), (int)n);
            }
        }
    }

