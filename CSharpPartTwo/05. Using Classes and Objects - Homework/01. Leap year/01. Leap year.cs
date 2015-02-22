using System;

class LeapYear
{
    static void Main()
    {
        //•	Write a program that reads a year from the console and checks whether it is a leap one.
        //•	Use System.DateTime.
        try
        {
            Console.Write("Enter year to check if it is leap: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("This year is leap? => {0}", DateTime.IsLeapYear(year));
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

    }
}

