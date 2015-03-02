using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //броя думи, с които работим
            int n = int.Parse(Console.ReadLine());
            var words = new List<string>();
            for (int i = 0; i < n; i++)//n на брои пъти четем някакъв стринг
            {
                words.Add(Console.ReadLine());//прочели сме думите
            }
            //правим n пъти размените
            for (int i = 0; i < n; i++)
            {
                //думата, с която работя е думата с индекс i
                var word =words[i];
                //i - думата, с която работя се намира на индекс i
                //индекса, на който трябва да вкарам този индекс е: len(w0) % (n+1), което като код изглежда:
                var newIndex = word.Length % (n + 1);//новият индекс се изчислява по следния начин: word.Length (дължината на думата) %(остатък от деление) с n + 1 
                
                words.Insert(newIndex, word);//вмъкваме думата без да я маркирам
                if (newIndex < i)//ако новия индекс, на който искам да сложа думата е по-малък от i
                {
                    words.RemoveAt(i + 1);//тогава думата, която ще трия ще е i + 1
                }
                else
                {
                    words.RemoveAt(i);//иначе махни елемента с индекс i
                }

                
                //хак на Наков
                //words[i] = null;//думата с индекс i т.е. предишната дума, която е била,то я прави null, т.е. такава дума вече няма, на този индекс вече няма дума
                //words.Insert(newIndex, word);//вмъкни ми думата word на новия индекс
                //words.Remove(null);//след това казва първото срещане на null го махни от списъка
            }
            //трябва ми най-дългата дума, за да знам докога ще обхождам буква по буква
            
            var maxLength = 0;
            foreach (var word in words)// за всяка дума
            {
                maxLength = Math.Max(maxLength, word.Length);//максималната стойност между досега намерената максимална(maxLength) и размера на думата(word.Length)
            }
            //може с LINQ да го направим
            //var maxLength = words.Max(x => x.Length);


            //хубаво е да използваме StringBuilder при конкатенация на стрингове
            var result = new StringBuilder();
            //вече знаем колко е най-дългата дума
            for (int i = 0; i < maxLength; i++)//от 0 до най-дългата дължина
            {
                //минаваме по всяка от думите
                foreach (var word in words)//всяка дума в списъка с думи
                {
                    if (word.Length > i)//ако думата, с която работим има дължина >= на индекса, с който искаме да бръкнем в нея, т.е. проверяваме да не излезнем от дължината на думата
                    {
                        //само тогава взимаме елемента и го вкарваме в StringBuilder-a
                        result.Append(word[i]);//прибавям елемента на думаата с индекс i
                    }
                    
                }
            }
            Console.WriteLine(result.ToString());//новополучения стринг, който сме натрупали в StringBuilder-a
        }
    }
}
