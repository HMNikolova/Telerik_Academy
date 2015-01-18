//5. Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is 7.


using System;

    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.Write("Please enter an integer: ");
            int intNumber = int.Parse(Console.ReadLine());
            bool thirdDigitIs7 = (intNumber / 100) % 10 == 7;
            Console.WriteLine("Is the third digit 7?: {0}", thirdDigitIs7);
        }
    }

