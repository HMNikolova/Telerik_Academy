namespace EverthingElse
{
    //за да използвам StringExtensions.cs namespace-овете трябва да са еднакви или да се добави using към кой namespace се отнася
    using System;
    using System.Linq;

    public static class StartingPoint
    {
        static void Main()
        {
            //искаме да направим string  да има допълнителна функционалност
            var text = "Pesho Gosho Ivan";
            var wordCount = text.CountWords();
            Conosle.WriteLine(wordCount);//3
            
            var anotherText = "C Sharp";
            var result = anotherText.CountWords();
            Conosle.WriteLine(result);
            
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
            list.IncreaseWithNumber(5);//6 7 8
        }
    }
}
