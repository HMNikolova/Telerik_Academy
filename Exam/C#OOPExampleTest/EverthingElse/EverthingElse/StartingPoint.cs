namespace EverthingElse.Extensions
{
    //за да използвам StringExtensions.cs namespace-овете трябва да са еднакви или да се добави using към кой namespace се отнася
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EverthingElse.Extensions;

    public static class StartingPoint
    {
        static void Main()
        {
            //искаме да направим string  да има допълнителна функционалност
            var text = "Pesho Gosho Ivan";
            var wordCount = text.CountWords();
            Console.WriteLine(wordCount);//3
            
            var anotherText = "C Sharp";
            var result = anotherText.CountWords();
            Console.WriteLine(result);
            
            //метода така написан в този клас не е нищо особено, то го разбира статичен метод в статичен клас и може да се извиква така:
            //ние не искаме така
            //StringExtensions.CountWords();
            //а да можем да кажем:
            //добавихме метода в StringExtensions.cs, който да ми върши работа и да мога да го извиквам върху самите стрингове
            //text.CountWords();
            
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            //IncreaseWithNumber какво ще очаква - числото, с което да го увеличим
            //защо очаква един параметър, а не два, защото първия е самия лист, който екстендваме
            //list.IncreaseWithNumber(5);//6 7 8
            
            //аноним тип данни - лошото е че не може да го подаваме на метод и т.н. и да го използваме вътре
            //вместо да създаваме друг клас и да го извикваме може да кажем така:
            var student = new {FirstName = "Pesho", ID = 155};
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.ID);
            var point = new {X = 5; Y = 6};
            Console.WriteLine(point.X);
            //анонимните типове са read only и след инициализацията на променлива вече не можем да променяме
        }
    }
}
