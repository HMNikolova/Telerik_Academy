using System;
using System.Numerics;

public class Program
{
     static string ConvertGagStringToNumber(string digit)
    {
        string result = "NO";
        switch (digit)
        {
            case "-!": result = "0"; break;
            case "**": result = "1"; break;
            case "!!!": result = "2"; break;
            case "&&": result = "3"; break;
            case "&-": result = "4"; break;
            case "!-": result = "5"; break;
            case "*!!!": result = "6"; break;
            case "&*!": result = "7"; break;
            case "!!**!-": result = "8"; break;


            default: break;
        }
        return result;
    }

    static BigInteger PowerOfNine(int power)
    {
        BigInteger result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= 9;
        }
        return result;
    }

    static void Main()
    {

        string input = Console.ReadLine();
        //стринг който ни пази на кой символ сме стигнали
        string partialInput = string.Empty;//частично влизаме в нашия стринг докато не намерим нещо смислино
        string nineSystemNumber = "";//числото което преврща символите
        for (int i = 0; i < input.Length; i++)
        {
            partialInput += input[i];//добавяме текущия символ

            string currentDigit = ConvertGagStringToNumber(partialInput);
            if (currentDigit != "NO")//ако ни върне цифра влизаме
            {
                nineSystemNumber += currentDigit;
                partialInput = "";//зачистваме
            }
        }
        //Console.WriteLine(nineSystemNumber);

        BigInteger result = 0;
        for (int i = 0; i < nineSystemNumber.Length; i++)
        {
            BigInteger digit = BigInteger.Parse(nineSystemNumber[i].ToString());
            result += digit * PowerOfNine(nineSystemNumber.Length - i - 1);
        }
        Console.WriteLine(result);

    }
}