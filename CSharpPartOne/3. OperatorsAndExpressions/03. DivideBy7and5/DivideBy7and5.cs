//3. Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

    class DivideBy7and5
    {
        static void Main()
        {
            Console.Write("Please enter an integer: ");
            int inputNum = int.Parse(Console.ReadLine());
            bool resultNum = (inputNum % 7 == 0) && (inputNum % 5 == 0) && (inputNum != 0);
            Console.WriteLine(resultNum);
        }
    }

