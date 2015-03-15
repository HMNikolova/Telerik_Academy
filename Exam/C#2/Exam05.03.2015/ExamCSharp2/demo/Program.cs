using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        //•	Write a program to convert hexadecimal numbers to their decimal representation.

        //string hex = Console.ReadLine().Trim();
        string[] words = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //string result = null;
        
        //foreach (var word in words)
        //{
        //    result += word;
            
        
        //}
        long decimalNumber = ConvertHexadecimalToDecimal(words);
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine("{0} = {1}", words[i], decimalNumber);
        }
        
    }

    private static long ConvertHexadecimalToDecimal(string[] words)
    {
        const int baseFormat = 23;

        long decimalNumber = 0;
        long power = 1;

        for (int index = words.Length - 1; index >= 0; index--)
        {
            string digit;

            switch (words[index])
            {
                case "a":
                    {
                        digit = "1";
                        break;
                    }
                case "b":
                    {
                        digit = 1;
                        break;
                    }
                case "c":
                    {
                        digit = 2;
                        break;
                    }
                case "d":
                    {
                        digit = 3;
                        break;
                    }
                case "e":
                    {
                        digit = 4;
                        break;
                    }
                case "f":
                    {
                        digit = 5;
                        break;
                    }
                case "j":
                    {
                        digit = 6;
                        break;
                    }
                case "h":
                    {
                        digit = 7;
                        break;
                    }
                case "i":
                    {
                        digit = 8;
                        break;
                    }
                case "g":
                    {
                        digit = 9;
                        break;
                    }
                case "k":
                    {
                        digit = 10;
                        break;
                    }
                case "l":
                    {
                        digit = 11;
                        break;
                    }
                case "m":
                    {
                        digit = 12;
                        break;
                    }
                case "n":
                    {
                        digit = 13;
                        break;
                    }
                case "o":
                    {
                        digit = 14;
                        break;
                    }
                case "p":
                    {
                        digit = 15;
                        break;
                    }
                case "q":
                    {
                        digit = 16;
                        break;
                    }
                case "r":
                    {
                        digit = 17;
                        break;
                    }
                case "s":
                    {
                        digit = 18;
                        break;
                    }
                case "t":
                    {
                        digit = 19;
                        break;
                    }
                case "u":
                    {
                        digit = 20;
                        break;
                    }
                case "v":
                    {
                        digit = 21;
                        break;
                    }
                case "w":
                    {
                        digit = 22;
                        break;
                    }
                
                default:
                    {
                        digit = words[index] - '0';

                        if (digit < 0 || digit > 23)
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

