//1. Exchange If Greater
//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

using System;

    class ExchangeIfGreater
    {
        static void Main()
        {   
            Console.Write("Enter the first variable: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second variable: ");
            double b = double.Parse(Console.ReadLine());
    		double c;
    
            if (a < b)
            {
                Console.WriteLine("{0} {1}",a,b);
            }
            else if (a > b)
            {
                c = a;
                a = b;
                b = c;
                Console.WriteLine("{0} {1}",a,b);
            }
            else if(a == b)
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }

