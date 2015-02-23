using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(100);
            numbers.Add(3);
            numbers.Add(50);

            //count - връща бройката вътре в колекцията
            //var result = numbers.Count();

            //пребой ми всички числа, такива, че за всяко число искам да е > 10
            //изкарва бройката на тези числа
            //var result = numbers.Count(n => n > 10);
            //Console.WriteLine(result);


            //numbers.FindAll(n => n > 10);
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //маха всички числа > 10
            //numbers.RemoveAll(x => x > 10);
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //намери ми всички числа, които при деление на 2 имат остатък 0
            //foreach (var number in numbers.FindAll(n => n % 2 == 0))
            //{
            //    Console.WriteLine(number);               
            //}
        }
    }
}
