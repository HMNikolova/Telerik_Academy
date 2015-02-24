using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static bool Print(int number)
        {
            if (number > 10)
            {
                return true;
            }
            return false;
        }
        
        static void Main(string[] args)
        {
            //var students = new List<string>();
            
            //students.Add("Pesho");
            //students.Add("Gosho");
            //students.Add("Ivan");
            //търсиме всички студенти, които не съдържат буквата "о"
            //var result = students.Where(st => !st.Contains('o'));
            //искам всички студенти, чиято първа буква е различна от "P" и след това ми ги сортирай по дължина
            //var result = students.Where(st => st[0] !='P').OrderBy(st => st.Length);//st[0] =='P' - така ще изкара всички, които започват с "P"
            //foreach (var item in result)
            //{
                //Console.WriteLine(item);
            //}
            
            
            
            //Delegate
            //в тип данни Func може да пазим ламбда функции или обикновени функции
            //първо трябва да кажем какъв параметър връща функцията и след това типа на функцията
            Func<int, bool> func = Print;
        }
    }
}
