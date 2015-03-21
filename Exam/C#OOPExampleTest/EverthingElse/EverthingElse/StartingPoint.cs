namespace EverthingElse
{
    //за да използвам StringExtensions.cs namespace-овете трябва да са еднакви или да се добави using към кой namespace се отнася
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EverthingElse.Extensions;

    public static class StartingPoint
    {
        //създаваме си делегат
        //public delegate void SomeDelegate(string input, int count);
        //може да кажем връщай ми инт и приемай един стринг
        //public delegate int SomeDelegate(string input);
        //може да си направя generic Delegate
        public delegate int SomeDelegate<T>(string input);

        //създаваме си метод за делегата
        public static void SomeMethod(string text, int number)
        {
            Console.WriteLine("Delegate call - " + text + number);

        }
        //създаваме си още един метод за делегата, който приема инт и връща стринг
        public static int AnotherMethod(string number)
        {
            Console.WriteLine("Special method 1");
            return 42;

        }
        public static int YetAnotherMethod(string number)
        {
            Console.WriteLine("Yet another special method 2");
            return 24;
        }


        public static void Main()
        {
            //променлива за делегата
            //var myDelegate = new SomeDelegate(SomeMethod);
            //или да кажа
            //SomeDelegate myDelegate = SomeMethod;
            //myDelegate("Pesho", 15);
            //и мога да кажа така
            //SomeDelegate myDelegate = int.Parse;
            //след като кажем по-нагоре, че искаме да е generic пишем:
            SomeDelegate<string> myDelegate = int.Parse;
            //за да пазим в делегата два метода
            myDelegate += AnotherMethod;
            //натрупване един след друг методи
            myDelegate += YetAnotherMethod;
            //и ако извикаме с минус YetAnotherMethod, той няма да бъде извикан
            myDelegate -= YetAnotherMethod;

            //анонимен метод
            myDelegate += delegate(string input)
            {
                Console.WriteLine("Anonymous method!");
                return 0;
            };

            //и ако подам 15
            //myDelegate ще извика двата метода един след друг 
            myDelegate("15");
            


            ////искаме да направим string  да има допълнителна функционалност
            //var text = "Pesho Gosho Ivan";
            //var wordCount = text.CountWords();
            //Console.WriteLine(wordCount);//3
            
            //var anotherText = "C Sharp";
            //var result = anotherText.CountWords();
            //Console.WriteLine(result);
            
            ////метода така написан в този клас не е нищо особено, то го разбира статичен метод в статичен клас и може да се извиква така:
            ////ние не искаме така
            ////StringExtensions.CountWords();
            ////а да можем да кажем:
            ////добавихме метода в StringExtensions.cs, който да ми върши работа и да мога да го извиквам върху самите стрингове
            ////text.CountWords();
            
            //var list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            ////IncreaseWithNumber какво ще очаква - числото, с което да го увеличим
            ////защо очаква един параметър, а не два, защото първия е самия лист, който екстендваме
            ////list.IncreaseWithNumber(5);//6 7 8
            
            ////аноним тип данни - лошото е че не може да го подаваме на метод и т.н. и да го използваме вътре
            ////вместо да създаваме друг клас и да го извикваме може да кажем така:
            ////var student = new {FirstName = "Pesho", ID = 155};
            ////Console.WriteLine(student.FirstName);
            ////Console.WriteLine(student.ID);
            ////var point = new {X = 5; Y = 6};
            ////Console.WriteLine(point.X);
            ////анонимните типове са read only и след инициализацията на променлива вече не можем да променяме
            
            ////ToString() при анонимните типове ни показва всичко, което има в ан.тип
            ////Console.WriteLine(student.ToString());
            
            ////колекция от анонимните типове
            //var ints = new [] {1,2,3};
            ////text.Split(new[] {' ', ','});//компилатора ще се сети че е масив от чарове(char)
            
            ////анонимен масив с анонимен тип
            //var students = new[]
            //{
            //    new {FirstName = "Ivan", LastName = "Peshov"},
            //    new {FirstName = "Petar", LastName = "Peshov"},
            //    new {FirstName = "Martin", LastName = "Peshov"}
            //};
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i].FirstName);
            //}
            
            
        }
    }
}
