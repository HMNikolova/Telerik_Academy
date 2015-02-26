using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseAndSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}


            //for (int index = 0; index < array.Length; index++)
            //{
            //    squares[index] = array[index] * array[index];
            //}


            //презаписваане на един масив в друг
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = arr1;
            //Console.WriteLine(arr1[1]);
            //Console.WriteLine(arr2[1]);
            //Console.WriteLine(new string('-', 10));
            //arr2[1] = 123;
            //Console.WriteLine(arr1[1]);
            //Console.WriteLine(arr2[1]);


            //клониране на масив и създаване на нов блок с памет
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = (int[])arr1.Clone();
            //Console.WriteLine(arr1[1]);
            //Console.WriteLine(arr2[1]);
            //Console.WriteLine(new string('-', 10));
            //arr2[1] = 123;
            //Console.WriteLine(arr1[1]);
            //Console.WriteLine(arr2[1]);
            ////indexOf първото срещанe определен елемент на кой индекс се намира в масив
            //Console.WriteLine(Array.IndexOf(arr1, 2)); 

            //indexOf второ срещанe на определен елемент на кой индекс се намира в масив
            //int[] arr1 = { 1, 44, 3, 44};
            //Console.WriteLine(Array.IndexOf(arr1, 44, 2)); 

            //обръщане на стоиностите в масив
            //int[] arr1 = { 1,2,3};
            //Array.Reverse(arr1);
            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            //подреждане на числа по абсолютна стойност
            //int[] arr1 = {6,1,-1,12,5};
            //arr1 = arr1.OrderBy(x => Math.Abs(x)).ToArray();
            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            //всички елементи които са по-малки от 0
            int[] arr1 = { 6, 1, -1, 12, 5 };
            arr1 = arr1.Where(x => x < 0).ToArray();
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }



            //колко елемента имаме в листа
            List<int> number = new List<int>
            {
                1,2,3,4,5,6,7
            };
            Console.WriteLine("Count: {0}", number.Count);
            //принтиране на масива с join
            Console.WriteLine(string.Join(", ", number));
            number.Add(1);
            Console.WriteLine("Count: {0}", number.Count);
            Console.WriteLine(string.Join(", ", number));
            number.Insert(5, 66);
            Console.WriteLine("Count: {0}", number.Count);
            Console.WriteLine(string.Join(", ", number));
            number.Remove(1);
            Console.WriteLine("Count: {0}", number.Count);
            Console.WriteLine(string.Join(", ", number));
            number.RemoveAt(1);
            Console.WriteLine("Count: {0}", number.Count);
            Console.WriteLine(string.Join(", ", number));
        }
    }
}
