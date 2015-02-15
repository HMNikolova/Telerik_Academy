using System;
using System.Text;

class BinaryToHexadecimal
{
    static void Main()
    {
        //•	Write a program to convert binary numbers to hexadecimal numbers (directly).
        string hexadecimalNumber = ConvertBinaryToHexadecimal(GetBinaryNumber());

        Console.WriteLine("Convert binary numbers to hexadecimal" +
            " numbers : {0}", hexadecimalNumber);
    }


    private static string ConvertBinaryToHexadecimal(string binaryNumber)
    {
        StringBuilder hexadecimalNumber = new StringBuilder();

        for (int index = 0; index < binaryNumber.Length; index += 4)
        {
            switch (binaryNumber.Substring(index, 4))
            {
                case "0000":
                    {
                        hexadecimalNumber.Append("0");
                        break;
                    }
                case "0001":
                    {
                        hexadecimalNumber.Append("1");
                        break;
                    }
                case "0010":
                    {
                        hexadecimalNumber.Append("2");
                        break;
                    }
                case "0011":
                    {
                        hexadecimalNumber.Append("3");
                        break;
                    }
                case "0100":
                    {
                        hexadecimalNumber.Append("4");
                        break;
                    }
                case "0101":
                    {
                        hexadecimalNumber.Append("5");
                        break;
                    }
                case "0110":
                    {
                        hexadecimalNumber.Append("6");
                        break;
                    }
                case "0111":
                    {
                        hexadecimalNumber.Append("7");
                        break;
                    }
                case "1000":
                    {
                        hexadecimalNumber.Append("8");
                        break;
                    }
                case "1001":
                    {
                        hexadecimalNumber.Append("9");
                        break;
                    }
                case "1010":
                    {
                        hexadecimalNumber.Append("A");
                        break;
                    }
                case "1011":
                    {
                        hexadecimalNumber.Append("B");
                        break;
                    }
                case "1100":
                    {
                        hexadecimalNumber.Append("C");
                        break;
                    }
                case "1101":
                    {
                        hexadecimalNumber.Append("D");
                        break;
                    }
                case "1110":
                    {
                        hexadecimalNumber.Append("E");
                        break;
                    }
                case "1111":
                    {
                        hexadecimalNumber.Append("F");
                        break;
                    }
            }
        }

        return hexadecimalNumber.ToString();
    }


    private static string GetBinaryNumber()
    {
        StringBuilder binaryNumber = new StringBuilder();
        bool isBinary;

        do
        {
            isBinary = true;

            Console.Write("Please, enter a binary number : ");
            string decimalNumber = Console.ReadLine().Trim();

            for (int index = 0; index < decimalNumber.Length; index++)
            {

                if (decimalNumber[index] < '0' || decimalNumber[index] > '1')
                {
                    isBinary = false;
                    break;
                }
            }

            if (decimalNumber.Length % 4 != 0)
            {
                string fill = new string('0', (1 * (4 - (decimalNumber.Length % 4))));
                binaryNumber.Append(fill);
            }

            binaryNumber.Append(decimalNumber);
        }
        while (!isBinary);

        return Convert.ToString(binaryNumber);
    }
}

