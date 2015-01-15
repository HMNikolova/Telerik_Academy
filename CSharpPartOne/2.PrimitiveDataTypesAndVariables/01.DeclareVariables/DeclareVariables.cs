// 1. Declare Variables

//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
//Submit the source code of your Visual Studio project as part of your homework submission.
//using System;

    class DeclareVariables
    {
        static void Main()
        {
            sbyte firstNumber  = -115;
            byte secondNumber = 97;
            short thirdNumber = -10000;
            ushort fourthNumber = 52130;
            int fifthNumber = 4825932;
            System.Console.WriteLine("sbyte is: {0}, byte is: {1}, short is: {2}, ushort is: {3}, int is: {4}", firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
        }
    }

