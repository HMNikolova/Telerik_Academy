using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSameArrayAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            //този лист е еквивалентен на долния масив
            //List<int> intList = new List<int>();
            //for (int i = 0; i < 5; i++)
            //{
            //    intList.Add(i);
                
            //}

            //int[] intArray = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    intArray[i] = i;
            //}


            //ПРЕЗАПИСВАНЕ НА МАСИВ ЗА ВКАРВАНЕ НА ДОПЪЛНИТЕЛНИ СТОЙНОСТИ

            //вмъкване на стойност на определена позиция
            //List<int> list = new List<int>();
            //list.Insert(5, 123);


            //AddRange добавя всички елементи от масива
            //int[] array = { 1, 2, 3, 4 };
            //List<int> listOfNmbers = new List<int>();
            //listOfNmbers.AddRange(array);

            //долепяне на списъци
            //int[] listOfOtherNmbers = new List<int>();
            //List<int> listOfNmbers = new List<int>();
            //listOfNmbers.AddRange(listOfOtherNmbers);

            
            //List<int> listofnmbers = new List<int>();
            //listofnmbers.AddRange(new[] {1,2,3,4});
            //Console.WriteLine(listofnmbers[3]);

            //дали дадено число се съдържа в списъка
            //List<int> listofnmbers = new List<int>();
            //listofnmbers.AddRange(new[] { 1, 2, 3, 4 });
            //Console.WriteLine(listofnmbers.Contains(3));

            //колко е дължината на масива
            //List<int> listofnmbers = new List<int>();
            //listofnmbers.AddRange(new[] { 1, 2, 3, 4 });
            //Console.WriteLine(listofnmbers.Count);

            //indexOf първото срещанe определен елемент на кой индекс се намира
            //List<int> listofnmbers = new List<int>();
            //listofnmbers.AddRange(new[] { 1, 2, 3, 4, 3});
            //Console.WriteLine(listofnmbers.IndexOf(3));

            //махане на първото срещане на елемент
            //list.Remove();

            //махане на всички срещания на елемента
            //List<int> listofnmbers = new List<int>();
            //listofnmbers.AddRange(new[] { 1, 2, 3, 4, 3 });
            //listofnmbers.RemoveAll(x => x == 3);
            //foreach (var item in listofnmbers)
            //{
            //    Console.WriteLine(item);
            //}

            //колко е капацитета заделен в списъка в момента
            //List<int> listNumbers = new List<int>();
            //listNumbers.AddRange(new[] { 1, 2, 3, 4 });
            //int capacity = listNumbers.Capacity;
            //Console.WriteLine(capacity);

            //обръщане на елементите от масива
            //List<int> listNumbers = new List<int>();
            //listNumbers.AddRange(new[] { 1, 2, 3, 4 });
            //listNumbers.Reverse();
            //foreach (var item in listNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            //сортиране на масив
            //List<int> listNumbers = new List<int>();
            //listNumbers.AddRange(new[] {7, 9, 15, 1, 2, 3, 4 });
            //listNumbers.Sort();
            //foreach (var item in listNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            //сортиране на синволни низове
            //List<string> listNumbers = new List<string>();
            //listNumbers.Add("bg");
            //listNumbers.Add("ab");
            //listNumbers.Add("za");
            //listNumbers.Sort();
            ////след това може да ги обърнем и да ни ги даде отзад напред
            //listNumbers.Reverse();
            //foreach (var item in listNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            //връща масив от елементите вътре в списъка
            //List<string> listNumbers = new List<string>();
            //listNumbers.Add("bg");
            //listNumbers.Add("ab");
            //listNumbers.Add("za");
            //string[] array = listNumbers.ToArray();
            //foreach (var item in listNumbers)
            //{
            //    Console.WriteLine(item);
            //}


            //подреди ми ги по дължината им
            //List<string> listNumbers = new List<string>();
            //listNumbers.Add("bag");
            //listNumbers.Add("ab");
            //listNumbers.Add("zadher");
            //listNumbers = listNumbers.OrderBy(x => x.Length).ToList();
            //foreach (var item in listNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            //всички символни низове, които първата им буква е 'а'
            //List<string> listNumbers = new List<string>();
            //listNumbers.Add("bag");
            //listNumbers.Add("ab");
            //listNumbers.Add("zadher");
            //listNumbers = listNumbers
            //    .Where(x => x[0] == 'a')
            //    .ToList();
            //foreach (var item in listNumbers)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
