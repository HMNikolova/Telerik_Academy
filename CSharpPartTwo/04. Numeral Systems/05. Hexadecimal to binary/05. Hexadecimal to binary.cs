using System;
using System.Text;

class HexadecimalToBinary
{
    static void Main()
    {
        //•	Write a program to convert hexadecimal numbers to their decimal representation.

        string binaryNumber = ConvertHexadecimalToBinary(GetHexadecimalNumber());

        Console.WriteLine("Convert hexadecimal numbers to binary " +
            "numbers : {0}", binaryNumber);
    }


    private static string ConvertHexadecimalToBinary(string hexadecimalNumber)
    {
        StringBuilder binaryNumber = new StringBuilder();

        for (int i = 0; i < hexadecimalNumber.Length; i++)
        {
            switch (hexadecimalNumber[i])
            {
                case '0':
                    {
                        binaryNumber.Append("0000");
                        break;
                    }
                case '1':
                    {
                        binaryNumber.Append("0001");
                        break;
                    }
                case '2':
                    {
                        binaryNumber.Append("0010");
                        break;
                    }
                case '3':
                    {
                        binaryNumber.Append("0011");
                        break;
                    }
                case '4':
                    {
                        binaryNumber.Append("0100");
                        break;
                    }
                case '5':
                    {
                        binaryNumber.Append("0101");
                        break;
                    }
                case '6':
                    {
                        binaryNumber.Append("0110");
                        break;
                    }
                case '7':
                    {
                        binaryNumber.Append("0111");
                        break;
                    }
                case '8':
                    {
                        binaryNumber.Append("1000");
                        break;
                    }
                case '9':
                    {
                        binaryNumber.Append("1001");
                        break;
                    }
                case 'A':
                    {
                        binaryNumber.Append("1010");
                        break;
                    }
                case 'B':
                    {
                        binaryNumber.Append("1011");
                        break;
                    }
                case 'C':
                    {
                        binaryNumber.Append("1100");
                        break;
                    }
                case 'D':
                    {
                        binaryNumber.Append("1101");
                        break;
                    }
                case 'E':
                    {
                        binaryNumber.Append("1110");
                        break;
                    }
                case 'F':
                    {
                        binaryNumber.Append("1111");
                        break;
                    }
                default:
                    {
                        binaryNumber.Append("");
                        break;
                    }
            }
        }

        return binaryNumber.ToString();
    }


    private static string GetHexadecimalNumber()
    {
        bool isHexadecimal;
        string hexadecimalNumber;

        do
        {
            isHexadecimal = true;

            Console.Write("Please, enter a hexadecimal number : ");
            Console.Write("hex = ");
            hexadecimalNumber = Console.ReadLine().Trim();

            for (int index = 0; index < hexadecimalNumber.Length; index++)
            {
                if ((hexadecimalNumber[index] < '0' || hexadecimalNumber[index] > '9') &&
                    (hexadecimalNumber[index] < 'A' || hexadecimalNumber[index] > 'F'))
                {
                    isHexadecimal = false;
                    break;
                }
            }
        }
        while (!isHexadecimal);

        return hexadecimalNumber;
    }
}

