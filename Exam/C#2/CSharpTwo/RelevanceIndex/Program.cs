using System;
using System.Collections.Generic;
public class Program
{

    public static string[] symbols = new string[] { " ", ",", ".", "(", ")", ";", "-", "!", "?" };

    public static void Main()
    {
        string searchWord = Console.ReadLine();//търсим дума
        int numberOfParagraphs = int.Parse(Console.ReadLine());//номера от параграфа
        //лист от стрингове, в който ще са ни параграфи
        List<string> paragraphs = new List<string>();
        //трябва да пазим, кой ни е relevanceIndex-а
        List<int> indexes = new List<int>();

        //още при четенето може да махнем пунктуацията
        for (int i = 0; i < numberOfParagraphs; i++)
        {
            //сплитни ми текущия ред
            string[] currentLineWords = (Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries));
            //преброяваме във всеки един параграф колко пъти се среща думата

            int relevanceIndex = 0;//променлива за брояч
            for (int j = 0; j < currentLineWords.Length; j++)//дължината на думите в currentLineWords 
            {
                string word = currentLineWords[j];
                //и двете ги правим на малки букви и тогава ги сравняваме
                if (word.ToLower() == searchWord.ToLower())//начин да сравняваме без да ни интересува дали са малки или големи букви
                {
                    relevanceIndex++;
                    //трябва да направим търсената дума в оригиналния текст на Upper
                    currentLineWords[j] = word.ToUpper();//текущата дума, ако съвпада, броя веднъж и я правя на главни букви
                }
            }

            //след като преправим и пребройм текущия параграф
            paragraphs.Add(string.Join(" ", currentLineWords));//такаотделяме думите със спейс
            indexes.Add(relevanceIndex);
        }
        //сортираме параграфите по relevanceIndex
        List<string> sortedParagraphs = new List<string>();//крайния резултат от сортирани параграфи ще ни бъде в sortedParagraphs
        while (sortedParagraphs.Count < paragraphs.Count)//докато не напълним sortedParagraphs да има същата бройка, значи не сме ги сортирали всичките
        {//т.е. докато не сме сортирали всички параграфи въртиш цикъла
            int maxIndex = 0;//търсим максималния relevanceIndex
            int maxParagraphIndex = 0;//това ни е мястото в масива за максималния параграфа
            for (int i = 0; i < indexes.Count; i++)//изцикляме си всички индекси
            {
                if (maxIndex < indexes[i])//търсим най-големия индекс
                {
                    maxIndex = indexes[i];
                    maxParagraphIndex = i;
                }
            }
            //когато намерим най-големия индекс го вкарваме в sortedParagraphs
            sortedParagraphs.Add(paragraphs[maxParagraphIndex]);//трябва да добавим от всичките параграфи този, който има (максимален релеванс индекс) maxParagraphIndex
            //и за да кажем, че този параграф вече не трябва да го взимаме, може да кажем
            indexes[maxParagraphIndex] = -1;
        }

        Console.WriteLine(string.Join(Environment.NewLine, sortedParagraphs));//ни връща символа за нов ред за текущия Environment
    }
}