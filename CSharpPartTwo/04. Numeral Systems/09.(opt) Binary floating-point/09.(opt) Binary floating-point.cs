using System;
using System.Collections.Generic;
using System.Text;

class BinaryFloatingPoint
{
    static void Main()
    {
        //•	Write a program that shows the internal binary representation of given 32-bit signed 
        //  floating-point number in IEEE 754 format (the C# type float).

        float floatNumber = GetNumber("a number");
        Console.WriteLine();

        BinaryRepresentationOf32BitFloatingPointNumber(floatNumber);
        Console.WriteLine();
    }


    private static void BinaryRepresentationOf32BitFloatingPointNumber(float number)
    {
        Console.WriteLine("The internal binary representation " +
            "of {0} in IEEE 754 format : ", number);
        Console.WriteLine("| {0} | {1,8} | {2,-23} |",
            "sign", "exponent", "mantissa");
        Console.Write("| {0,4} | {1} | {2} |",
            GetSign(number), GetExponent(number), GetMantissa(number));
    }

    private static string GetSign(float number)
    {
        if (number >= 0)
        {
            return "0";
        }
        else
        {
            return "1";
        }
    }

    private static string GetDecimalToBinaryFraction(float number)
    {
        StringBuilder fraction = new StringBuilder();

        float temp = number - (int)number;

        do
        {
            temp *= 2;

            fraction.Append((int)temp);

            temp -= (int)temp;

        } while (temp != 0);

        return fraction.ToString();
    }

    private static string GetMantissa(float number)
    {
        if (number < 0)
        {
            number *= -1;
        }

        string integer = ConvertDecimalToBinary((int)number);

        string fraction = GetDecimalToBinaryFraction(number);

        StringBuilder mantissa = new StringBuilder();

        if (integer.Length != 0)
        {
            mantissa.Append(integer.Substring(1) + fraction);
        }
        else
        {
            mantissa.Append(fraction.Substring(fraction.IndexOf('1') + 1));
        }

        return mantissa.ToString().PadRight(23, '0');
    }

    private static string GetExponent(float number)
    {
        StringBuilder exponent = new StringBuilder();

        if (number < 0)
        {
            number *= -1;
        }

        int exp = (int)(Math.Floor(Math.Log(number, 2)));

        exponent.Append(ConvertDecimalToBinary(exp + 127));

        return exponent.ToString();
    }

    private static string ConvertDecimalToBinary(int decimalNumber)
    {
        const int baseFormat = 2;

        List<int> binaryNumber = new List<int>();

        while (decimalNumber != 0)
        {
            binaryNumber.Add((decimalNumber % baseFormat));
            decimalNumber /= baseFormat;
        }

        StringBuilder result = new StringBuilder();

        for (int index = binaryNumber.Count - 1; index >= 0; index--)
        {
            result.Append(binaryNumber[index]);
        }

        return Convert.ToString(result);
    }

    private static float GetNumber(string name)
    {
        float number = float.MinValue;
        bool isNumber = false;

        do
        {
            Console.Write("Please, enter {0}: ", name);
            isNumber = float.TryParse(Console.ReadLine().Trim(), out number);
        }
        while (isNumber == false);

        return number;
    }
}

