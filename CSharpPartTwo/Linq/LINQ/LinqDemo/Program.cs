using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //средна стойност
            //var texts = new List<string>();
            //texts.Add("Pesho");
            //texts.Add("Ivan");
            //texts.Add("Stamat");
            //var result = texts.Average(t => t.Length);
            
            //    Console.WriteLine(result);


            var numbers = new List<int>();
            numbers.Add(15);
            numbers.Add(5);
            numbers.Add(124);
            //Average на всички числа събрани с 10
            //var result = numbers.Average(t => t + 10);
            //преброй ми всички елементи, които се делят на 2
            //var result = numbers.Count(t => t % 2 == 0);
            //Console.WriteLine(result);
            //var result = numbers.Max();
            //var result = numbers.Min();
            //var result = numbers.Sum();
            var result = numbers.Where(n => n > 10).Sum();
            Console.WriteLine(result);
        }
    }
}
