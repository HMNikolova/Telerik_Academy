
namespace CTSExercise
{
    using System;
    using System.Collections.Generic;
    public class EntryPoint
    {
        public static void PrintIfCat(IAnimal animal)
        {
            //is сравнява типове
            if (animal is Cat)
	        {
		            Console.WriteLine("Yes!");
	        }
            else if (animal is Dog)
            {
                Console.WriteLine("No, I am dog!");
            }
            else
	        {
                Console.WriteLine("No!");
	        }
        }

        public static void Main()
        {
            //IEnumerator
            var cates = new List<Cat>
            {
                new Cat { Name = "Misho" },
                new Cat { Name = "Petko" },
                new Cat { Name = "Drago" }
            };
            var owners = new Owner(cates);
            foreach (var cats in owners)
            {
                Console.WriteLine(cats.Name);
            }

            ////as оператора каства
            //IAnimal dog = new Dog();
            ////ако кучето е куче
            //if (dog is Dog)
            //{
            //    //искам да го кастнеш към куче
            //    var dogAsDog = (Dog)dog;
            //    dogAsDog.Name = "Veso";
            //    Console.WriteLine(dogAsDog.Name);
            //}

            ////as оператора може да го направим да не гърми, но връща null, така:
            //IAnimal firstAnimal = new Dog();
            //IAnimal secondAnimal = new Cat();
            //var firstAnimalAsDog = firstAnimal as Dog;
            //if (firstAnimalAsDog != null)
            //{
            //    Console.WriteLine(firstAnimalAsDog.Name);
            //}
            //var secondAnimalAsDog = secondAnimal as Dog;
            ////Console.WriteLine(secondAnimalAsDog == null);

            //var firstAnimal = new Cat();
            //var secondAnimal = new Cat();
            var firstAnimal = new Cat { Age = 5 };
            var secondAnimal = new Cat { Age = 1 };
            var anotherCats = new Cat();

            var listCats = new List<Cat> { firstAnimal, secondAnimal};
            var owner = new Owner(listCats);
            //понеже връща обект трябва да го кастна
            //от тук нататък имаме два owner-а, които са единтични, които сме клонирали по алгоритъма в Owner.cs
            Owner anotherOwner = (Owner)owner.Clone();

            ////за MemberwiseClone - на втория клонирания добавяме нова котка, на първия не добавяе нищо
            anotherOwner.Add(anotherCats);
            Console.WriteLine(owner);
            Console.WriteLine(anotherOwner);

            Console.WriteLine();
            //SortedSet е структура от данни, която ни пази сортирани уникални елементи 
            //второто предимство е че ако вкарвам всякакви стойности разбъркано
            //той автоматично ги сортира и ги сортира бързо
            //var sortedSet = new SortedSet<int>();

            //sortedSet.Add(5);
            //sortedSet.Add(2);
            //sortedSet.Add(100);
            //sortedSet.Add(1);
            //sortedSet.Add(1);
            ////Console.WriteLine(sortedSet.Count);
            //foreach (var number in sortedSet)
            //{
            //    Console.WriteLine(number);
            //}

            var sortedSet = new SortedSet<Cat>();
            sortedSet.Add(firstAnimal);
            sortedSet.Add(secondAnimal);
            //вади ни ги сортирани както сме поискали в CompareTo в Cat.cs
            foreach (var number in sortedSet)
            {
                Console.WriteLine(number.Age);
            }


            Console.WriteLine();
            var cat = new Cat();
            cat.Name = "Gosho";
            //ще ми изкара Yes!
            PrintIfCat(cat);
            //ако създадем ново Dog
            PrintIfCat(new Dog());

            var anotherCat = new Cat();
            anotherCat.Name = "Gosho";

            var thirdCat = cat;
            //така вече може да сравним обектите
            Console.WriteLine(cat.Equals(anotherCat));
            bool areEqual = cat == anotherCat;
            Console.WriteLine(areEqual);
            bool areEquals = cat != anotherCat;
            Console.WriteLine(areEquals);
            //GetHashCode
            Console.WriteLine(anotherCat.GetHashCode());
            //override на обекта
            Console.WriteLine(cat.ToString());

            Console.WriteLine();
            //GetType така наречения рефлекшън - рънтайм да изследваме какво е писано по кода
            //т.е. докато програмата работи да се изследва сама и да прави някакви неща
            //GetType - когато имаме конкретна променлива върху която го извикваме (конкретна инстанция)
            //GetProperties -колекция от всички пропъртита, които са дефинирани в този тип данни
            var properties = cat.GetType().GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine(property.Name);
                //за това пропърти вземи ми някаква стойност на конкретна котка
                Console.WriteLine(property.Name + " " + property.GetValue(cat));
            }

            Console.WriteLine();
            //typeof - когато нямаме инстанция, прави същото като GetType
            //в единия случай взимаме информация за типа от конкретна инстанция
            //в другия случай взимаме информация за типа от конкретния тип
            var propertiesTheSame = typeof(Cat).GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine(property.Name);
                Console.WriteLine(property.Name + " " + property.GetValue(cat));
            }

            Console.WriteLine();
            //може да търсим конкретен метод
            var methodEquals = typeof(Cat).GetMethod("Equals");
            Console.WriteLine(methodEquals.Name);

            ////изкарване на всичките методи на Console
            //var consoleType = typeof(Console);
            //var methods = consoleType.GetMethods();
            //foreach (var method in methods)
            //{
            //    Console.WriteLine(method.Name);
            //}

            Console.WriteLine();
            //инстанция на котка runtime
            var catRuntime = Activator.CreateInstance<Cat>();

            //сравнява адресите дали савпадат в паметта, но тъй като cat и anotherCat
            //са в различни парчета памет areEquales ще каже false
            var areEquales = object.ReferenceEquals(cat,anotherCat);
            Console.WriteLine(areEquales);
        }
    }
}
