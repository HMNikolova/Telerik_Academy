using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int>();
        //добавяне на числа
        numbers.Add(5);
        numbers.Add(10);
        //изваждане колко бройки имаме в list-a
        Console.WriteLine(numbers.Count);
        //как да вземем 2-рия елемент
        Console.WriteLine(numbers[1]);

        //list има индексатор, hashSet няма индексатор, но пази уникални стойности
        //колекцията HashSet, в която може да пазим уникални стойности, тук обаче нямаме индексация
        HashSet<int> numbersSet = new HashSet<int>();
        numbersSet.Add(1);
        numbersSet.Add(1);
        numbersSet.Add(1);
        numbersSet.Add(1);
        numbersSet.Add(1);
        numbersSet.Add(4);
        numbersSet.Add(5);
        numbersSet.Add(5);

        Console.WriteLine(numbersSet.Count);//изкарва само една 1-ца, защото изкарва уникална стойност, 
        //ако са три различни стойности изкарва числото 3, защото са 3 различни уникални стойности в листа

        //с foreach може да изкарваме различните уникални числа в листа, но няма гаранция в какъв вариант ще ни върне стойностите
        foreach (var number in numbersSet)
        {
            Console.WriteLine(number);
        }


        //SortedSet - пази уникални стойности, но ги пази сортирани
        SortedSet<int> sortedNumbers = new SortedSet<int>();

        sortedNumbers.Add(10);
        sortedNumbers.Add(10);
        sortedNumbers.Add(2);
        sortedNumbers.Add(5);
        sortedNumbers.Add(5);
        sortedNumbers.Add(5);

        foreach (var number in sortedNumbers)
        {
            Console.WriteLine(number);
        }


        //приема два параметъра, работи точно като масив, но ние му казваме какъв тип данни да бъде индекса
        //т.е. казваме искам индекса да ми бъде стринг, а стойностите, които ще пазя вътре да бъдат (int) числа
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        dictionary["pesho"] = 12;
        Console.WriteLine(dictionary["pesho"]);

        Dictionary<char, int> dict = new Dictionary<char, int>();
        dict['a'] = 7;
        dict['b'] = 10;
        bool cont = dict.ContainsKey('b');//съдържа ли се даден ключ вече в речника
        Console.WriteLine(cont);
        Console.WriteLine(dict['a']);

        Console.WriteLine();
        var diction = new Dictionary<string, int>();
        diction["Pesho"] = 2;
        diction["Dosho"] = 15;
        diction["Ivan"] = 30;

        foreach (var item in diction)
        {
            Console.WriteLine(item.Key + "-" + item.Value);
        }

        //сортиран речник
        var sortedDict = new SortedDictionary<int, string>();


        sortedDict[5] = "Gosho";
        sortedDict[26] = "Ivan";
        sortedDict[11] = "Pesho";

        foreach (var item in sortedDict)
        {
            Console.WriteLine(item.Key + "-" + item.Value);//сортира ги по ключ
        }

    }
}