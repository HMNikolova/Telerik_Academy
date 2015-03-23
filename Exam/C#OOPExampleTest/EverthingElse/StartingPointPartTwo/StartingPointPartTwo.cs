namespace StartingPointPartTwo
{
    
    //за да използвам StringExtensions.cs namespace-овете трябва да са еднакви или да се добави using към кой namespace се отнася
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StartingPointPartTwo.Extensions;

    public static class StartingPoint
    {
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

        //създаваме си метод за делегата
        public static void SomeMethod(string text, int number)
        {
            Console.WriteLine("Delegate call - " + text + number);

        }

        //подаване на делегат на друг метод, т.е. може да подадем Action на метод
        public static void PrintMethod(Action<string, int> action)
        {
            action("15", 5);
        }

        //public static int ReturnAnswerToEverything(string input, long number)
        public static int ReturnAnswerToEverything()
        {
            return 42;
        }

        public static void Main()
        {
            //може да си направим лист от студенти
            var lists = new List<Student> 
            {
                new Student {FirstName = "Ivan", LastName = "Ivanov"},
                new Student {FirstName = "Ivan", LastName = "Ivanov"},
            };
            
            
            var list = new List<int> {1,2,6,3,8,10};
            var lessThanFive = 
            from n in list//всяко число n, което се намира вътре в листа
            where n < 5 && n != 3//искам да ми направиш where заявка където n<5 и е различно от 3
            //orderby n//сортирай ми ги по самото число
            select n + 100;//селектирай ми n и ми добави 100
            //select n + 100.ToString();//или мога да ги стрингосам
            foreach (var number in lessThanFive)
            {
                Console.WriteLine(number);
            }
            
            //правим си нов клас 2:02:00
            //ако искаме да върнем повече от една стойност си правим клас и тук казваме
            Func<string, string, Student> studentGenerator = (x,y) => new {FirstName = x, LastName = y };//това ми генерира студенти
            var someStudent = studentGenerator("Pesho", "Ivanov");
            
            //Predicate - Получаваме нещо и връщаме bool
            //n => n > 3 - това нещо наричаме Predicate, защото връща true или false
            var numbers = new List<int> {1,2,3,4};
            var filteredNumbers = numbers.Where(n => n > 3);
            //също може да кажем
            var cities = new List<string> {"Sofia", "Varna", "Burgas"};
            //намери ми всички, които като ги направиш с малки букви и започват с s са валидни
            var filteredCities = cities.Where(c => c.ToLower().StartsWhit("s")).ToList();
            
            //ламбда израз
            Action<int> action = x => Console.WriteLine(x);
            action(5);
            
            //var pets = new[]
                //{
                    //new {Name="Sharo", Age=8},
                    //new {Name="Rex", Age=4},
                    //new {Name="Strela", Age=1},
                   // new {Name="Bora", Age=3}
                //};
            ////OrderBy по какъв начин да ми ги сортира
            //pets.OrderBy(p => p.Age).ForEach(p => Console.WriteLine(p.Name));
            
            //всяко нещо, което може да бъде foreach-вано с дефолтния foreach e IEnumerable

            //искам за всеки един елемент да ми изпълниш някакъв метод
            //var numbers = new int[] { 3,4,5,6};
            ////или колекция
            //var numbers = new List<int> { 3, 4, 5, 6 };
            //var removeNumber = numbers.FindAll(x => x > 4);

            //всяка една колекция ние я екстенднднахме да има foreach метод и за този foreach аз мога да кажа
            //искам foreach за всеки елемент вътре - изпълни ми cw
            ////т.е. аз му казвам какъв Action да изпълни и той казва добре аз ще го изпълня
            //numbers.ForEach(x => Console.WriteLine(x));

            //този ламбда израз представлява - приема един параметър(параметъра, който е вътре в колекцията) и не връща нищо
            //очевидно този ламбда израз е някакъв Action от типа данни, който е в numbers
            //т.е
            //Action<int> myAction = x =>
            //    {
            //        Console.WriteLine("Telerik");
            //        Console.WriteLine(x);
            //    };//защото аз му подавам инт и вътре принтирам Telerik и самия инт
            //т.е. като знам, че това е Action аз мога да направя extension(разширен) метод,
            //който да се казва ForEach, той да приема Action и да ми изпълнява каквото му кажа

            //искам да мога да кажа ForEach - за всеки ми изпълни следното
            numbers.ForEach(x =>
                {
                    Console.WriteLine("Telerik");
                    Console.WriteLine(x);
                });
            

            //какво има в linq
            //имаме колекция от интове
            //var list = new List<int> { 4, 3, 0, 1243 };
            //OrderBy - Подреди по
            //var sortedList = list.OrderBy(x => x).ToList();
            //или
            //var list = new List<string> { "4564645", "3ad", "0", "1243" };
            //var sortedList = list.OrderBy(x => x.Length).ToList();//подрежда ги по дължина
            
            //Action може да пази всякакви делегати, които не връщат стойности(т.е. които са void), типовете на generic(Т1,Т2,Т3) всъщност са параметрите, които приема дадения метод 
            //правя си Action от типовете, които са в SomeMethod
            //Action върши работа като деледат, който не връща нищо
            Action<string, int> myMethod = SomeMethod;
            //извиква се като му подадем string, int
            myMethod("", 0);

            //може и така
            PrintMethod(myMethod);

            //вграден делегат, който е удобен за използване
            //Action<string> cw = Console.WriteLine;

            //Func - последния параметър, който сетнем е тази стойност, която се връща от метода
            //в този func мога да пазя всякакъв метод, който връща интове и не приема никакви стойности
            //последната стойност, която е в дженериците на func е типа данни, който връща даден метод
            //всичките преди това са параметрите, които той приема т.е.
            //в този func мога да пазя всякакви методи, които приемат string и long и връщат int и за да работи горе в метода ReturnAnswerToEverything трябва да кажа
            //Func<string, long, int> func = ReturnAnswerToEverything;
            //и за да го извикаме правим
            //func ("15", 15415864);
            Func<int> func = ReturnAnswerToEverything;   
            
            //Lambda изрази - съкратен запис на метод
            //приема стринг връща инт
            //Func<string, int> funcs = x => 42;
            //или функция, която очаква стинг и връща инт, казваме искам х да ми е такова, че int.Parse парсва х
            //Func<string, int> funcs = x => int.Parse(x);
            //int result = func("15");

            //за да може да го дебъгнем трябва да изглежда така:
            //Func<string, string, int> funcs = x =>
            //    {
            //        return int.Parse(x);
            //    };

            //Lambda израза е метод, който е написан директно вътре в кода и се използва на едно място, но със съкратен запис
            //Func<string, string, int> funcs = (x, y) =>
            //    {
            //        Console.WriteLine(x, y);
            //        return 42;
            //    };
            //или
            //Func<string, string, int> funcs = (x, y) => 42;
            //ако не искаме да има параметри, които се приемат
            Func<int> funcs = () => 42;
            int result = func();
        }
    }
}
 
