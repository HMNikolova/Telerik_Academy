using System;
using System.Collections.Generic;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        //•	Write a program to convert decimal numbers to their binary representation.
        long decimalNumber = GetNumber("a decimal number ( " +
                long.MinValue + " <-> " + long.MaxValue + " )");
        Console.WriteLine();

        Console.Write("Convert decimal numbers to their binary " +
            "representation : {0}", ConvertDecimalToBinary(decimalNumber));
        Console.WriteLine();
    }


    private static string ConvertDecimalToBinary(long decimalNumber)
    {
        const int decimalFormat = 64;
        const int baseFormat = 2;

        List<long> binaryNumber = new List<long>();

        if (decimalNumber >= 0)
        {
            // positive numbers
            while (decimalNumber != 0)
            {
                binaryNumber.Add((decimalNumber % baseFormat));
                decimalNumber /= baseFormat;
            }

            while ((binaryNumber.Count % decimalFormat != 0) || binaryNumber.Count == 0)
            {
                binaryNumber.Add(0);
            }
        }
        else
        {
            // negative numbers
            while (decimalNumber != 0)
            {
                binaryNumber.Add(((decimalNumber * (-1)) % baseFormat));
                decimalNumber /= baseFormat;
            }

            while (binaryNumber.Count % decimalFormat != 0)
            {
                binaryNumber.Add(1);
            }
        }

        StringBuilder result = new StringBuilder();

        for (int index = binaryNumber.Count - 1; index >= 0; index--)
        {
            result.Append(binaryNumber[index]);
        }

        return Convert.ToString(result);
    }

    private static int GetNumber(string name)
    {
        int number = int.MinValue;
        bool isNumber = false;

        do
        {
            Console.Write("Please, enter {0}: ", name);
            isNumber = int.TryParse(Console.ReadLine(), out number);
        }
        while (isNumber == false);

        return number;
    }
}
