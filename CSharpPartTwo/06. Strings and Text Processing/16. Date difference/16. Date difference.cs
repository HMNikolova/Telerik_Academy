using System;

class DateDifference
{
    static void Main()
    {
        //•	Write a program that reads two dates in the format:
        //  day.month.year and calculates the number of days between them.
         try
        {
            Console.Write("Enter the first date in format[day.month.year]: ");
            string[] inputOne = Console.ReadLine().Split('.');
            int dayOne = int.Parse(inputOne[0]);
            int monthOne = int.Parse(inputOne[1]);
            int yearOne = int.Parse(inputOne[2]);
            DateTime dateOne = new DateTime(yearOne, monthOne, dayOne);

            Console.Write("Enter the second date in format[day.month.year]: ");
            string[] inputTwo = Console.ReadLine().Split('.');
            int dayTwo = int.Parse(inputTwo[0]);
            int monthTwo = int.Parse(inputTwo[1]);
            int yearTwo = int.Parse(inputTwo[2]);
            DateTime dateTwo = new DateTime(yearTwo, monthTwo, dayTwo);

            int daysBetween = Math.Abs((dateOne - dateTwo).Days);
            Console.WriteLine("Distance: {0} days", daysBetween);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

