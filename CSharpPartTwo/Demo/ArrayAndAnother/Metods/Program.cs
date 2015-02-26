using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    class Program
    {
        //универсален суматор - приема аргументи от различен тип и знае как да ги сумира
        //метода sum искам да работи с тип данни T
        public static T Stack<T>(T[] arr, Func<T, T, T> stackMethod)
        {
        T stack = default (T);
        foreach (var item in arr)
	{
        stack = stackMethod(stack, item);
	}
        return stack;
    }

        public static void Main()
        {
            string[] items = new[] { "Niki", "Ivo", "Evlogi" };
            Func<string, string, string> sum = (s1, s2) => s1 + s2;           
            Console.WriteLine(Stack<string>(items, sum));
        }

        //отговор 0
        //public static void ChangeValue(int[] a)
        //{
        //    a = new int[] { 0 };
        //    a[0] = 10;
        //}
        //public static void Main()
        //{
        //    int[] a = {0};
        //    ChangeValue(a);
        //    Console.WriteLine(a[0]);
        //}


        //отговор 10
        //public static void ChangeValue(int[] a)
        //{
        //a[0] = 10;
        //}
        //public static void Main()
        //{
        //int[] a = {0};
        //ChangeValue(a);
        //Console.WriteLine(a[0]);
        //}



        //отговор 0
        //public static void ChangeValue(int a)
        //{
        //a = 10;
        //}
        //public static void Main()
        //{
        //int a = 0;
        //ChangeValue(a);
        //Console.WriteLine(a);
        //}

        ////отговор 10 - метода как променя "a"
        //static int ChangeValue(int a)
        //{
        //a = 10;
        //return a;
        //}
        //static void Main()
        //{
        //int a = 0;
        //a = ChangeValue(a);
        //Console.WriteLine(a);
        //}

        //отговор 10 - добаврне на "а" по референция
        //static int ChangeValue(ref int a)
        //{
        //    a = 10;
        //    return a;
        //}
        //static void Main()
        //{
        //    int a = 0;
        //    a = ChangeValue(ref a);
        //    Console.WriteLine(a);
        //}

        //отговор 123 и 10
        //static void ChangeValue(ref int[] a)
        //{
        //    a = new int[] { 123, 10 };
           
        //}
        //static void Main()
        //{
        //    int[] a = new[] {0};
        //    ChangeValue(ref a);
        //    Console.WriteLine(a[0]);
        //    Console.WriteLine(a[1]);
        //}

        //static void PrintLogo(string CompanyLogo)
        //{
            //void означава че метода не връща никаква стойност
            //() - метода не приема аргументи
        //    Console.WriteLine(CompanyLogo);
        //    Console.WriteLine("www.telerik.com");
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Before print logo");
        //    PrintLogo("Telerik 2015");
        //    Console.WriteLine("After print logo");
        //}


        //static void PrintSign(int number)
        //{
        //    if (number > 0)
        //    {
        //        Console.WriteLine("The number {0} is positive.", number);
        //    }
        //    else if (number < 0)
        //    {
        //        Console.WriteLine("The number {0} is negative.", number);
        //    }
        //    else
        //    {
        //        Console.WriteLine("The number {0} is zero.", number);
        //    }
        //}

        //static void PrintMax(float number1, float number2)
        //{
        //    float max = number1;
        //    if (number2 > number1)
        //    {
        //        max = number2;
        //    }
        //    Console.WriteLine("Maximal number: {0}", max);
        //}

        //static void Main()
        //{
        //    Console.Write("n = ");
        //    int n = int.Parse(Console.ReadLine());

        //    Console.Write("m = ");
        //    int m = int.Parse(Console.ReadLine());

        //    PrintSign(n);
        //    PrintSign(m);
        //    PrintMax(n, m);
        //}
    }
}
