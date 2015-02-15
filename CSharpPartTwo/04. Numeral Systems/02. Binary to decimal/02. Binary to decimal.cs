using System;

class BinaryToDecimal
{
    static void Main()
    {
        //•	Write a program to convert binary numbers to their decimal representation.
        Console.WriteLine("Please, enter a binary integer number !");
        Console.Write("binaryNumber = ");
        string binaryNumber = Console.ReadLine().Trim();

        long decimalNumber = ConvertBinaryToDecimal(binaryNumber);

        Console.WriteLine("Convert binary numbers to their " +
                    "decimal representation : {0}", decimalNumber);
    }

    private static long ConvertBinaryToDecimal(string binaryNumber)
    {
        const int decimalFormat = 64;

        long decimalNumber = 0;

        if (binaryNumber.Length <= decimalFormat)
        {
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[i] != '1' && binaryNumber[i] != '0')
                {
                    throw new ArgumentException("You must enter a binary number !");
                }

                decimalNumber = (decimalNumber << 1) + (binaryNumber[i] == '1' ? 1 : 0);
            }
        }
        else
        {
            throw new ArgumentOutOfRangeException("The binary number is too big !");
        }

        return decimalNumber;
    }
}

