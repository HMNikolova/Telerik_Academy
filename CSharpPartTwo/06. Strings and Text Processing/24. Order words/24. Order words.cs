﻿using System;

class OrderWords
{
    static void Main()
    {
        //•	Write a program that reads a list of words, separated by spaces 
        //  and prints the list in an alphabetical order.
        Console.WriteLine("Enter text: ");
         string text = Console.ReadLine();
        string[] words = text.Split(' ');

        Array.Sort(words);
        Console.WriteLine("Your words in alphabetical order: ");
        Console.WriteLine(string.Join(" ", words));
    }
}
