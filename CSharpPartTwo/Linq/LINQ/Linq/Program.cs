using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ работи върху всяка една структура от данни, която е колекция
            //Linq винаги връща нов резултат, linq не променя оригиналната колекция, той създава нова 
            var numbers = new List<int>();

            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(100);
            numbers.Add(2);
            numbers.Add(50);

            //where - извади ми всички, които отговарят на дадено условие
            //искам от numbers да ми извадиш всичките, за които всяко число 
            //е такова, че самото число е > 10

            //функция, която не приема параметри
            //var lambda = () => Console.WriteLine();
            //функция, която приема 2 параметри
            //var lambda = (x, y) => Console.WriteLine(x + y);
            
            var result = numbers.Where(n => n > 10);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //горното е същото като долното
            //numbers.Where(n =>
            //    {
            //        if (n > 10)
            //        {
            //            return true;
            //        }
            //        return false;
            //    });

            //var result = new List<int>();


            //foreach (var number in numbers)
            //{
            //    if (number > 10)
            //    {
            //        result.Add(number);
            //    }
            //}
            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}
        }
    }
}
