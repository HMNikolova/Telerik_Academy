﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger inputNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger number = inputNumber;
            if (number < 0)
            {
                number = -number;
            }

            int specialSum = 0;
            int currentDigitPosition = 0;
            while (number > 0)
            {
                int currentDigit = (int)(number % 10);
                currentDigitPosition++;
                if (currentDigitPosition % 2 == 1)
                {
                    specialSum += currentDigit * currentDigitPosition * currentDigitPosition;
                }
                else
                {
                    specialSum += currentDigit * currentDigit * currentDigitPosition;
                }

                number /= 10;
            }
            Console.WriteLine(specialSum);

            int secretSequenceLength = specialSum % 10;
            if (secretSequenceLength != 0)
            {
                char firstSecretLetter = (char)(specialSum % 26 + 'A');
                for (int offset = 0; offset < secretSequenceLength; offset++)
                {
                    char secretLetter = (char)(firstSecretLetter + offset);
                    if (secretLetter > 'Z')
                    {
                        secretLetter = (char)(secretLetter - 'Z' + 'A' - 1);
                    }

                    Console.Write(secretLetter);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("{0} has no secret alpha-sequence", inputNumber);
            }
        }
    }
}
