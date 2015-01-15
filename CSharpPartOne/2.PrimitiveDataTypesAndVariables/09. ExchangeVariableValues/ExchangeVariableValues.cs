//9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

using System;

    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Before the exchange: ");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            int exchangeVar = a;
            a = b;
            b = exchangeVar;

            Console.WriteLine("After the exchange: ");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

        }
    }

