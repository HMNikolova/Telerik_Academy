using System;
using System.Collections.Generic;
using System.Text;

class BinaryShort
{
    static void Main()
    {
        //•	Write a program that shows the binary representation of given 16-bit signed 
        //  integer number (the C# type short).

        short decimalNumber = GetNumber("a decimal number ( " +
               short.MinValue + " <-> " + short.MaxValue + " )");
        Console.WriteLine();

        Console.Write("Convert decimal numbers to their binary " +
            "representation : {0}", ConvertDecimalToBinary(decimalNumber));
        Console.WriteLine();
    }


    private static string ConvertDecimalToBinary(long decimalNumber)
    {
        const int decimalFormat = 16;
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

    private static short GetNumber(string name)
    {
        short number = short.MinValue;
        bool isNumber = false;

        do
        {
            Console.Write("Please, enter {0}: ", name);
            isNumber = short.TryParse(Console.ReadLine(), out number);
        }
        while (isNumber == false);

        return number;
    }
}
