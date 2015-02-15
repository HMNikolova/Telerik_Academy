using System;
using System.Text;

class DecimalToHexadecimal
{
    static void Main()
    {
        //•	Write a program to convert decimal numbers to their hexadecimal representation.
        long decimalNumber = GetNumber("a decimal number");

        string hexadecimalNumber = ConvertDecimalToHexadecimal(decimalNumber);

        Console.WriteLine("Convert decimal numbers to their hexadecimal " +
            "representation : {0}", hexadecimalNumber);
    }

    private static string ConvertDecimalToHexadecimal(long decimalNumber)
    {
        const int baseFormat = 16;

        StringBuilder reversedHexNumber = new StringBuilder();

        while (decimalNumber > 0)
        {
            long remainder = decimalNumber % baseFormat;

            switch (remainder)
            {
                case 10:
                    {
                        reversedHexNumber.Append('A');
                        break;
                    }
                case 11:
                    {
                        reversedHexNumber.Append('B');
                        break;
                    }
                case 12:
                    {
                        reversedHexNumber.Append('C');
                        break;
                    }
                case 13:
                    {
                        reversedHexNumber.Append('D');
                        break;
                    }
                case 14:
                    {
                        reversedHexNumber.Append('E');
                        break;
                    }
                case 15:
                    {
                        reversedHexNumber.Append('F');
                        break;
                    }
                default:
                    {
                        reversedHexNumber.Append(remainder);
                        break;
                    }
            }

            decimalNumber /= baseFormat;
        }

        StringBuilder hexNumber = new StringBuilder();

        for (int i = reversedHexNumber.Length - 1; i >= 0; i--)
        {
            hexNumber.Append(reversedHexNumber[i]);
        }

        return hexNumber.ToString();
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

