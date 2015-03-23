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
            //екстеншън методите ни връщат нова колекция(обект)
            //where
            //listOfStudents.Where(st => st.Mark != 2);
            //за да взема студентите, трябва да създам нова променлива и вече новата колекция ще се запише в новата променлива
            var filter = listOfStudents.Where(st => st.Mark != 2);
            //първи елемент, който е в колекцията
            var first = listOfStudents.First();
            //същото е ако кажем
            var first = listOfStudents.Where(st => st.Mark > 2).First();
            //ако няма нищо в колекцията FirstOrDefault ще върне null, а First ще гръмне
            var first = listOfStudents.FirstOrDefault();
            //на FirstOrDefault може да кажем първия, който отговаря на дадено условие
            var first = listOfStudents.FirstOrDefault(st => st.Mark > 2);
            //с select/cast може да трансформираме оригиналните обекти в нещо друго т.е. селектираме само част от тези обекти
            var lastNames = listOfStudents.Select(st => new {Mark = st.Mark, FullName = st.FirstName + " " + st.LastName});
            //за да кастнем първо трябва да селектираме
            var lastNames = listOfStudents.Where(st => st.Mark > 2).Select(st => st).Cast<object>().ToList();
            //подредба на колекции - подреди ми първо по LastName и ако някъде съвпадат по FirstName
             var lastNames = listOfStudents.Where(st => st.Mark > 2).OrderByDescending(st => st.LastName).ThenByDescending(st => st.FirstName).ThenBy(st => st.Mark).ToList();
            //Any и All връщат bool - искам да проверя дали някой изпълнява някои условия
            //Any - ако поне един от студентите има оценка > 2 връща true
            var lastNames = listOfStudents.Any(st => st.Mark > 2);
            //All - дали всички изпълняват дадено условие
            var lastNames = listOfStudents.All(st => st.Mark > 2);
            //AsEnumerable - връща ни същата колекция
            var lastNames = listOfStudents.Where(st => st.Mark > 2).AsEnumerable().ToList();
            //Reverse - обръща дадена колекция
            var lastNames = listOfStudents.Where(st => st.Mark > 2).Reverse().ToList();
            //Average - средно аритметично
            var averageMark = listOfStudents.Average(st => st.Mark);
            //Sum
            var sumMark = listOfStudents.Sum(st => st.Mark);
            //Max - намира макс. ст-ст, която се намира вътре, Min е на същия принцип
            var maxMark = listOfStudents.Max(st => st.Mark);
            //Count - ще ги преброи
            var countMark = listOfStudents.Count(st => st.Mark > 2);
            
            //2:55:00
            
            //може да си направим лист от студенти
            var listOfStudents = new List<Student> 
            {
                new Student {FirstName = "Ivan", LastName = "Ivanov", Mark = 2},
                new Student {FirstName = "Dragan", LastName = "Draganov", Mark = 4},
                new Student {FirstName = "Petkan", LastName = "Petkanov", Mark = 6},
                new Student {FirstName = "Martin", LastName = "Vilqnov", Mark = 3}
            };
            
            //екстеншън методи с ламбда изрази
            var filteredStudents = 
            //искам да ми вземеш всеки един студент такъв, че LastName да започва с буквата g
            listOfStudents.Where(st.LastName.StartWhit("G"))
            //след това ми ги подреди по оценка наобратно
            .OrderByDescending(st => st.Mark)
            //селектирай ми всеки студент, дай ми от него нов обект, който има само LastName
            .Select(st => new {LastName = st.LastName})
            //за да ни се върне като лист
            .ToList();
            foreach (var student in filteredStudents)
            {
                Console.WriteLine(student.LastName);
            }
            
            ////nested заявки от колекции и да ги джоинваме
            //var numbers = new[] {1,2,3,4};
            //var cartesianProduct = 
            //from student in listOfStudents
            //from number in listOfStudents
            //select new {Id = number, Name = student.LastName};
            //foreach (var selected in cartesianProduct)
            //{
                //Console.WriteLine(selected.Id + " " + selected.Name);
            //}
            
            ////nested заявки (декартово произведение)
            //var cartesianProduct = 
           ////за всеки един студент ще вземе всички останали
            //from st1 in listOfStudents
            //from st2 in listOfStudents
            ////where st1.LastName != st2.LastName//за да не ми ги повтаря
            //select new {FirstStudent = st1.LastName, SecondStudent = st2.LastName};
            //foreach (var selected in cartesianProduct)
            //{
                //Console.WriteLine(selected.DirstStudent + " " + selected.SecondStudent);
            //}
            
            //от всеки студент в листа със студенти, намери ми тези, на които оценката е по-голяма от 2 и ми ги подреди по LastName, и ми селектирай цялото име
            var passedStudents = 
            from student in listOfStudents
            where student.Mark > 2
            orderby student.LastName
            select student.FirstName + " " + student.LastName;
            //group student by student.Mark;//може и да ги групирам, но ще трябва да ползвам два foreach-a и да махна горния select
            //foreach (var group in passedStudents)
            //{
                //Console.WriteLine(group.Key);
                //foreach (var student in group)
                    //{
                        //Console.WriteLine(student.FirstName + " " + student.LastName);
                   // }
            //}
            foreach (var student in passedStudents)
            {
                //принтира ми всички LastName, които нямат 2-ка 
                Console.WriteLine(student);
            }
            
            
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
            
            //преброяване колко пъти се среща дадена дума в текст
            var text = "Hi, I C Sharp C Sharp C Sharp";
            var search = "sharp";
            var result = text
            .Split(' ')
            .Where(w => w.ToLower() == search.ToLower())
            //.Count();//ще ги преброи
            .ToList();//връща ги като лист
            Console.WriteLine(result);
            //стринга е масив от чарове и може да кажем
            var results = text.Where(s => s == 'c' || s == 'C').Count();
            Console.WriteLine(results);
            
            //правим си нов клас 2:02:00 има го в https://dotnetfiddle.net/
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
 
