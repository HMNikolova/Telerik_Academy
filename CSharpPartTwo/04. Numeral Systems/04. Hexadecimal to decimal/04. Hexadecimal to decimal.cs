using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        //•	Write a program to convert hexadecimal numbers to their decimal representation.
        Console.WriteLine("Please, enter a hexadecimal number !");
        Console.Write("hex = ");
        string hex = Console.ReadLine().Trim();

        long decimalNumber = ConvertHexadecimalToDecimal(hex);

        Console.WriteLine("decimal = {0}", decimalNumber);
    }

    private static long ConvertHexadecimalToDecimal(string hex)
    {
        const int baseFormat = 16;

        long decimalNumber = 0;
        long power = 1;

        for (int index = hex.Length - 1; index >= 0; index--)
        {
            int digit;

            switch (hex[index])
            {
                case 'A':
                    {
                        digit = 10;
                        break;
                    }
                case 'B':
                    {
                        digit = 11;
                        break;
                    }
                case 'C':
                    {
                        digit = 12;
                        break;
                    }
                case 'D':
                    {
                        digit = 13;
                        break;
                    }
                case 'E':
                    {
                        digit = 14;
                        break;
                    }
                case 'F':
                    {
                        digit = 15;
                        break;
                    }
                default:
                    {
                        digit = hex[index] - '0';

                        if (digit < 0 || digit > 9)
                        {
                            throw new ArgumentException("You must enter " +
                                "a hexadecimal number !");
                        }
                        break;
                    }
            }

            decimalNumber += digit * power;
            power *= baseFormat;
        }

        return decimalNumber;
    }
}

