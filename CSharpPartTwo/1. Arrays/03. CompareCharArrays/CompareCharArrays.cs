//3. Compare char arrays
//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Collections.Generic;
using System.Linq;

    class CompareCharArrays
    {
        static void Main()
        {
            Console.Write("Enter first word: ");
            char[] firstWord = Console.ReadLine().ToCharArray();
            Console.Write("Enter second word: ");
            char[] secondWord = Console.ReadLine().ToCharArray();
            string lexFirst = string.Join("", firstWord);
            int length = Math.Min(firstWord.Length, secondWord.Length);
            for (int i = 0; i < length; i++)
			{
                if (firstWord[i] > secondWord[i])
	        {
		         lexFirst = string.Join("", secondWord);
                 break;
	        }
			}
            Console.WriteLine("Lexicographically first is: {0}", lexFirst);


        }
    }

