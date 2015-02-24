using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        //static bool Print(int number)
        //{
            //if (number > 10)
            //{
                //return true;
            //}
            //return false;
        //}
        
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
            //Func<int, bool> func = Print;
            //func(9);
            //не приема никакви параметри и връща bool
            //Func<bool> func = (Print) () => true;
            
            //Action - функции, които не връщат нищо
            //Console.WriteLine() - приема string и не връща нищо
            //Action<string> action = Console.WriteLine(); 
            //Action<string> action = x => Console.WriteLine(x);
            
            //LINQ - вкарани в езика вградени заявки
            //string text = "Pesho %123";
            //преброй ми всички символи, които са букви
            //var result = text.Count(s => char.IsLetter(s));
            //преброй ми всички цифри
            //var result = text.Count(s => char.IsDigit(s));
            //Console.WriteLine(result);
            
            var numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(124);
            numbers.Add(15);
            //искам всички числа, които при деление на 5 имат остатък 0
            //var result = numbers.Where(n => n % 5 == 0);
            //или всяко число, което не се дели на 2
            //var result = numbers.Where(n => n % 2 != 0);
            
            //първото намерено число или дефолтното
            //var first = numbers.Where(n => == 200).FirstOrDefault();
            //може и без where 
            //var first = numbers.FirstOrDefault(n => n != 5);
            //var first = numbers.First(x => x > 100);
            //var first = numbers.Last(x => x == 5);
            //така ще гръмне и ще разберем, че има грешка
            //var first = numbers.Where(n => == 200).First();
            //така ще гръмне и ще разберем, че има грешка
            //var first = numbers.Where(n => == 200).Last();
            //последното намерено число или дефолтното
            //var first = numbers.Where(n => == 200).LastDefault();
            
            //сортирай ми числата всяко по себе си и ми вземи първото
            //var first = numbers.OrederBy(x => x).First();
            //сортирай ми числата всяко по себе си в обратен ред и ми вземи първото
            //var first = numbers.OrederByDescending(x => x).First();
            
            //foreach (var number in result)
            //{
                //Console.WriteLine(number);
            //}
        }
    }
}
