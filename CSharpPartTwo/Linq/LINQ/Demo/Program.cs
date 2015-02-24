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
            
            //var numbers = new List<int>();
            //numbers.Add(5);
            //numbers.Add(10);
            //numbers.Add(124);
            //numbers.Add(15);
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
            
            
            //Select() и Cast() може да прехвърлим един тип данни в друг
            //var texts = new List<string>();
            //text.Add("1");
            //text.Add("2");
            //text.Add("3");
            //със Select() казваме какво точно искаме да селектираме от колекцията
            //var result = texts.Select(t => int.Parse(t));
            //var result = texts.Select(t => int.Parse(t + 6));//така ще ни залепи по една 6 зад всяко число
            //foreach (var number in result)
            //{
                //Console.WriteLine(number + 5);//така ще ни прибави 5 към всяко едно число
            //}
            
            //изкарва дължините на стринговете -> 5,4,6
            var texts = new List<string>();
            texts.Add("Pesho");
            texts.Add("Ivan");
            texts.Add("Stamat");
            //var result = texts.Select(t => t.Length);
            //искам тези дължини да ми ги подредиш
            //var result = texts.Select(t => t.Length).OrderBy(l => l);
            //и искам пак да ми ги селектираш и да ми добавиш 12 за всеки
            //var result = texts.Select(t => t.Length).OrderBy(l => l).Select(t => t + 12);
            //селектирай ми ги по първа буква
            //var result = texts.Select(t => t[0]);
            //селектирай ми ги по първа буква
            //var result = texts.Select(t => t.First());
            //ако му кажем после Where, работим с върнатото от Selecta
            //var result = texts.Select(t => t.First()).Where();
            //так работим с върнатото от Selecta
            //var result = texts.Where(t[0] != 'P').Select(t => t.First());
            //така ще ни изкара само Ivan
            //var result = texts.OrderBy(t => t.Length).Where(t[0] != 'P').First());
            //подреди ми го по дължина, после по първа буква
            //var result = texts.OrderByDescending(t => t.Length).ThenBy(t => t[0]);
            //var result = texts.OrderByDescending(t => t.Length).ThenByDescending(t => t[0]);
            
            //Any и All, вървят ръка за ръка и връщат bool
            //дали някои елемент от колекцията отговаря на дадено условие
            //връща true ако поне едното е истина
            //bool result = texts.Any(t => t[0] == 'P');
            //Console.WriteLine(result);
            //за да върне true трябва всички да започват с 'P'
            //bool result = texts.All(t => t[0] == 'P');
            //foreach (var number in result)
            //{
                //Console.WriteLine(number + 5);//така ще ни прибави 5 към всяко едно число
            //}
            
            //var texts = new List<string>();
            //texts.Add("1");
            //texts.Add("2");
            //texts.Add("3");
            //var result = texts.Select(int.Parse);//съкратен запис
            //var result = texts.Select(t => int.Parse(t)).First().//от тук нататък не можем да правим нищо, защото това вече не е колекция
        
            //с ToList накрая си оправяме проблема, ако ни се кара, че иска лист    
            //List<string> result = texts.OrderBy(t => t).Where(t => t[0] == 'P' && t[t.Length - 1] == 'P').ToList();
            //ако ни трябва масив с ToArray() се оправят нещата
            //string[] result = texts.OrderBy(t => t).Where(t => t[0] == 'P' && t[t.Length - 1] == 'P').ToArray();
            //засега с var е достатъчно
            //var result = texts.OrderBy(t => t).Where(t => t[0] == 'P' && t[t.Length - 1] == 'P');
            var result = texts.OrderBy(t => t).Reverse();
            //понеже Linq си има собствен reverse, трябва да се запише по следния начин, за да се оточни, че се извиква от Linq
            //var result = texts.AsEnumerable().Reverse();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
