﻿using System;
using System.Globalization;
using System.Text;
class DateInBulgarian
{
    static void Main()
    {
        /*•	Write a program that reads a date and time given in the format:
         * day.month.year hour:minute:second and prints the date and time 
         * after 6 hours and 30 minutes (in the same format) along with the 
         * day of week in Bulgarian.*/
        Console.Write("Enter a date and time in the format [dd.MM.yyyy HH:mm:ss]: ");
        string input = Console.ReadLine();
        DateTime date = DateTime.ParseExact(input, "d.M.yyyy H:m:s", CultureInfo.GetCultureInfo("bg-BG"));
        date = date.AddHours(6.5);
        Console.WriteLine(date.ToString("dddd d.M.yyyy HH:mm:ss"));
        }
    }

