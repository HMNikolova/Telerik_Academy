namespace StartingPointPartTwo
{

    //за да използвам StringExtensions.cs namespace-овете трябва да са еднакви или да се добави using към кой namespace се отнася
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StartingPointPartTwo;
    using System.Dynamic;

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

        //подаване на делегат на друг метод, т.е. може да подадем Action на метод
        public static void PrintMethod(Action<string, int> action)
        {
            action("15", 5);
        }

        //public static int ReturnAnswerToEverything(string input, long number)
        public static int ReturnAnswerToEverything()
        {
            return 42;
        }

        public static void Main()
        {
            
        }
    }
}

