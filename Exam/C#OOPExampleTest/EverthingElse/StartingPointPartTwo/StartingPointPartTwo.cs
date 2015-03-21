namespace EverthingElse
{
    //1:03:41 - Action може да пази всякакви делегати, които не връщат стойности(т.е. които са void), типовете на generic(Т1,Т2,Т3) всъщност са параметрите, които приема дадения метод 

    //за да използвам StringExtensions.cs namespace-овете трябва да са еднакви или да се добави using към кой namespace се отнася
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public static class StartingPoint
    {
        //създаваме си още един метод за делегата, който приема инт и връща стринг
        public static int AnotherMethod(string number)
        {
            Console.WriteLine("Special method 1");
            return 42;

        }
        public static int YetAnotherMethod(string number)
        {
            Console.WriteLine("Yet another special method 2");
            return 24;
        }

        //създаваме си метод за делегата
        public static void SomeMethod(string text, int number)
        {
            Console.WriteLine("Delegate call - " + text + number);

        }

        public static void Main()
        {

        }
    }
}
