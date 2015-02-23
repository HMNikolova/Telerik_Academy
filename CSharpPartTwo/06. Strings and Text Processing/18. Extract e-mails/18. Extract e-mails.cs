using System;
using System.Text.RegularExpressions;

class ExtractEMails
{
    static void Main()
    {
       //•	Write a program for extracting all email addresses from given text.
       //•	All sub-strings that match the format @… should be recognized as emails.
        string text = "These emails: abv@yahoo.  @cocacola.com now@you is are not valid.These emails: test@abv.bg or goto@gmail.com are valid.";
        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string regex = @"^([a-zA-Z0-9_\-][a-zA-Z0-9_\-\.]{0,49})" + @"@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+[a-zA-Z]{2,4})$";

        Console.WriteLine("Extracted e-mail addresses: ");
        for (int i = 0; i < words.Length; i++)
        {
            if (Regex.IsMatch(words[i],regex))
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}

