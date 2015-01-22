//12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            int? isNullInteger = null;
            Console.WriteLine("This is the integer with null value -> {0}", isNullInteger); 
            isNullInteger = 5;
            Console.WriteLine("This is the integer with null value 5 -> {0}", isNullInteger);

            double? isNullDouble = null;
            Console.WriteLine("This is the double with null value -> {0}", isNullDouble);
            isNullDouble = 5.5;
            Console.WriteLine("This is the double with null value 10 -> {0}", isNullDouble);
        }
    }

