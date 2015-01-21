/*15.* Age after 10 Years
 * Write a program to read your birthday from the console and 
 * print how old you are now and how old you will be after 10 years.
 */

using System;

    class AgeAfter10Years
    {
        static void Main()
        {
            Console.Write("Enter your birthday (yyyy.mm.dd): ");
            string myBirthday = Console.ReadLine();
            DateTime myDTBirthday = DateTime.Parse(myBirthday);
            DateTime nowDT = DateTime.Now;
            int myAge = nowDT.Year - myDTBirthday.Year;
            if (nowDT.Month < myDTBirthday.Month)
            {
                myAge = myAge - 1;
            }
            else if (nowDT.Month == myDTBirthday.Month)
            {
                if (nowDT.Day < myDTBirthday.Day)
                {
                    myAge = myAge - 1;
                }
            }
            Console.WriteLine("Today, you are {0} years old.", myAge);
            Console.WriteLine("After 10 years you will be {0} years old", myAge + 10);
        }
    }

