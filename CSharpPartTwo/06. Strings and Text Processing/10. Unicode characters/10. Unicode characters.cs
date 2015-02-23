using System;
using System.Text;
class UnicodeCharacters
{
    static void Main()
    {
       //•	Write a program that converts a string to a sequence of C# Unicode character literals.
       //•	Use format strings.
    string str = "Hi!";
        byte[] uniByte = Encoding.Unicode.GetBytes(str);
        string uniString = string.Empty;
        foreach (byte b in uniByte)
        {
            if (b == 0)
            {
                continue;
            }
            uniString += string.Format("{0}{1}", "\\u",b.ToString("X").PadLeft(4,'0'));
        }
        Console.WriteLine(uniString);
    }
}

