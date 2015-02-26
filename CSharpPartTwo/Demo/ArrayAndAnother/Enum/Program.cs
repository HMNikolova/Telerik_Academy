﻿using System;

class EnumerationsDemo
{
    public enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    };

    static void Main()
    {
        //ако User въвежда някакъв номер и да познае какъв цвят е 
        int userInput = 1;
        Day day = (Day)userInput;
        Console.WriteLine(day);

        switch (day)//и два пъти enter и изкарва дните от седмицата
        {
            case Day.Monday:
                break;
            case Day.Tuesday:
                break;
            case Day.Wednesday:
                break;
            case Day.Thursday:
                break;
            case Day.Friday:
                break;
            case Day.Saturday:
                break;
            case Day.Sunday:
                break;
        }

        // This will not compile
        //Day first = 1;

        Day nextDay = day + 1;
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(nextDay);

        Day thirdDay = (Day)3;
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(thirdDay);

        string sundayStr = "Sunday";
        //string към enum
        Day sunday = (Day)Enum.Parse(typeof(Day), sundayStr);
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(sunday);

        Console.ResetColor();
    }
}