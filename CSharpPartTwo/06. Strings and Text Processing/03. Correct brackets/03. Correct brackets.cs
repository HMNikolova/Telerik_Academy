using System;
using System.Collections.Generic;

class CorrectBrackets
{
    //•	Write a program to check if in a given expression the brackets are put correctly.


    static void Main()
    {
        Console.Write("Enter expression with brackets: ");
        string input = Console.ReadLine();

        bool isCorrect = true;
        int open = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(') open++;
            if (input[i] == ')') open--;
            if (open < 0) isCorrect = false;
        }

        if (open != 0) isCorrect = false;
        Console.WriteLine("Brackets are put correctly: {0}", isCorrect);
    }
    }


