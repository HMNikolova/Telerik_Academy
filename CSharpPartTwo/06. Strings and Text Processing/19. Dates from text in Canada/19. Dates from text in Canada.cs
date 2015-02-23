using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

    class DatesFromTextInCanada
    {
            /*•	Write a program that extracts from a given text all dates that match the 
             * format DD.MM.YYYY.
              •	Display them in the standard date format for Canada.*/
        static void Main()
        {
            string input = "I was born at 15.12.1982 .In 1999 ....At 3.03.2014 ....";
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                try
                {
                    DateTime date = DateTime.ParseExact(words[i].TrimEnd(new char[] { ',', '.', '!', '?' }), "d.M.yyyy",
                                CultureInfo.InvariantCulture);
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");
                    Console.WriteLine("Canada (english): {0}", date.Date.ToLongDateString());
                }
                catch (FormatException)
                {
                }
            }
        }
        }


