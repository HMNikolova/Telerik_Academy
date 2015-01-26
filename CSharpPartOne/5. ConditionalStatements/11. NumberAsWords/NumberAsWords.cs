//11.* Number as Words
//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

    class NumberAsWords
    {
        static void Main()
        {
            bool correctNumber;
        int number;
        int resultHundreds = 0;
        int resultTens = 0;
        int resultOnes = 0;
        do
        {
            Console.Write("Write an integer number in the range [0-999]: ");
            string strNumber = (Console.ReadLine());
            correctNumber = int.TryParse(strNumber, out number);
        } while (correctNumber == false);
        if (number > 99)
        {
            resultHundreds = number / 100;
            switch (resultHundreds)
            {
                case 1: Console.Write("One hundred "); break;
                case 2: Console.Write("Two hundred "); break;
                case 3: Console.Write("Three hundred "); break;
                case 4: Console.Write("Four hundred "); break;
                case 5: Console.Write("Five hundred "); break;
                case 6: Console.Write("Six hundred "); break;
                case 7: Console.Write("Seven hundred "); break;
                case 8: Console.Write("Eight hundred "); break;
                case 9: Console.Write("Nine hundred "); break;
            }
            if (number % 100 != 0)
            {
                Console.Write("and ");


            }
        }

        if ((number % 100) > 19)
        {
            resultTens = (number % 100) / 10;
            switch (resultTens)
            {
                case 2: Console.Write("twenty"); break;
                case 3: Console.Write("thirty"); break;
                case 4: Console.Write("forty"); break;
                case 5: Console.Write("fifthy"); break;
                case 6: Console.Write("sixty"); break;
                case 7: Console.Write("seventy"); break;
                case 8: Console.Write("eighty"); break;
                case 9: Console.Write("ninety"); break;
            }
        }
        if (((number % 100) < 10) || ((number % 100) > 19))
        {
            resultOnes = number % 10;

            switch (resultOnes)
            {
                case 1: Console.Write("one"); break;
                case 2: Console.Write("two"); break;
                case 3: Console.Write("three"); break;
                case 4: Console.Write("four"); break;
                case 5: Console.Write("five"); break;
                case 6: Console.Write("six"); break;
                case 7: Console.Write("seven"); break;
                case 8: Console.Write("eight"); break;
                case 9: Console.Write("nine"); break;
            }
        }
        else
        {
            resultTens = number % 100;
            switch (resultTens)
            {
                case 10: Console.WriteLine("ten"); break;
                case 11: Console.WriteLine("eleven"); break;
                case 12: Console.WriteLine("twelve"); break;
                case 13: Console.WriteLine("thirteen"); break;
                case 14: Console.WriteLine("fourteen"); break;
                case 15: Console.WriteLine("fifteen"); break;
                case 16: Console.WriteLine("sixteen"); break;
                case 17: Console.WriteLine("seventeen"); break;
                case 18: Console.WriteLine("eighteen"); break;
                case 19: Console.WriteLine("nineteen"); break;
            }
        }
        if (number == 0)
        {
            Console.WriteLine("Zero");
        }
        Console.WriteLine();
        }
    }

