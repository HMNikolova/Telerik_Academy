using System;
using System.Collections.Generic;
using System.Text;

class ReverseSentence
{
    static void Main()
    {
        //•	Write a program that reverses the words in given sentence.
         string text = "C# is not C++, not PHP and not Delphi!";

        string[] words = text.Split(new char[] { ' ', '!', '?', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        List<char> signs = new List<char>();

        for (char i = 'a'; i <= 'z'; i++)
        {
            signs.Add(i);
        }
        for (char i = 'A'; i <= 'Z'; i++)
        {
            signs.Add(i);
        }
        for (char i = '0'; i <= '9'; i++)
        {
            signs.Add(i);
        }
        signs.Add('#');
        signs.Add('+');
        string[] splitElements = text.Split(signs.ToArray(), StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        var reversedText = new StringBuilder();

        for (int i = 0; i < splitElements.Length; i++)
        {
            reversedText.Append(words[i]);
            reversedText.Append(splitElements[i]);
        }
        Console.WriteLine(reversedText.ToString());
    }
}

