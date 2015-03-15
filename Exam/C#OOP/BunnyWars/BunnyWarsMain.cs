namespace BunnyWars
{
    using Animals;
    using Bunnies;
    using System;
    using System.Collections.Generic;
    class BunnyWarsMain
    {
        //static void ChangeBunny(Bunny bunny)//когато подаваме обект във функция той се подава по референция, ако го променя някаде в кога той се променя навсякъде
        //    {//като при масивите е
        //        bunny.Health = 0;
        //    }

        static void Main()
        {
            Bunny vankataBunny = new Bunny("Vankata");//конструктора ни има параметър, затова трябва да сложим параметър(име в скобите) на новия заек
            //vankataBunny.ChangeColor("Red");//метода сменя цвета
            //Bunny blueBunny = new Bunny("Pesho", "Red");//така използваме втория конструктор
            //с currentVankataCarrots може да поискаме текущия резултат 
            ulong currentVankataCarrots = vankataBunny.AddCarrots(100);

            //Console.WriteLine("Vankata carrots = " + currentVankataCarrots);
            Bunny peshoBunny = new Bunny("Peshoоо", "Blue");
            ulong currentPeshoCarrots = peshoBunny.AddCarrots(2000);
            //Console.WriteLine(currentPeshoCarrots + " " + currentVankataCarrots);//зсеки нов създаден заек си пази собствените данни

            string vankataName = vankataBunny.Name;

            vankataBunny.Color = "Blue";//blue отива и се записва като value в set-ъра
            string color = vankataBunny.Color;

            vankataBunny.Health = 150;
            //Console.WriteLine(vankataBunny.Health);

            //Console.WriteLine(vankataName);

            vankataBunny.Retire();
            vankataBunny.Health -= 250;
            vankataBunny.Retire();
            //Console.WriteLine(vankataBunny.IsRetire);

            //Animal animal = new Animal();

            Console.WriteLine(Bunny.NumberOfLegs);//Bunny.NumberOfLegs - static така се използва, защото е общо за всички зайци

            string someString = null;
            string anotherString = someString ?? "Default";//?? - казва, ако someString е null дай ми Default
            //Console.WriteLine(anotherString);

            //Bunny baiGosho = new Bunny("Goshooo");
            //Console.WriteLine(baiGosho.Health);//100
            //ChangeBunny(baiGosho);
            //Console.WriteLine(baiGosho.Health);//0 - променя се навсякъде, това идва от функцията ChangeBunny

            var bunnies = new List<Bunny>();

            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                Bunny currentBunny = new Bunny(new string((char)i, 10));
                currentBunny.Health = random.Next(0, 100);
                bunnies.Add(currentBunny);
            }

            //foreach (var bunny in bunnies)
            //{
            //    Console.WriteLine(bunny.Name + " " + bunny.Health);
            //    //Console.WriteLine(bunny.Health);
            //}

            //начални стойности на Лист от зайци
            var vankataAndPesho = new List<Bunny>
            {
                vankataBunny,
                peshoBunny
            };

            //foreach (var bunny in vankataAndPesho)
            //{
            //    Console.WriteLine(bunny.Name);
            //}

            AirCraft firstAirCraft = new AirCraft(vankataBunny, 50);
            AirCraft seccondAirCraft = new AirCraft(peshoBunny, 100);

            firstAirCraft.Attack(seccondAirCraft);

            Console.WriteLine(seccondAirCraft.Pilot.Health);

            //преместване на корабите
            firstAirCraft.Move(new Coordinates(15, 20));
            seccondAirCraft.Move(new Coordinates(25, 40)); 

            //идеята на статичния метод
            double distance = AirCraft.CalculateDistance(firstAirCraft, seccondAirCraft);
            Console.WriteLine(distance);//това е разтоянието по формулата, като е взело от всеки кораб текущото разстояние

            Console.WriteLine(vankataBunny.Damage);

            ColorEnum colorType = ColorEnum.Red;
            Console.WriteLine(colorType);

            Bunny bunny = new Bunny("Bunnyyyy");
            Console.WriteLine(bunny);//това bunny ще си извика ToString метода

            //Animal bunny2 = new Bunny("Bunny2");
             //bunny2. - няма нищо от заека има от животното
            //bunny2.

            object bunny2 = new Bunny("dsadasdasd");
            //кастване
            Bunny nqkakvoBunny = bunny2 as Bunny;//за да имам данните на бънито -> bunny2 as Bunny - с дуги думи му казваме аз искам да използвам този обект като Bunny
            //може да го кастнем и така:
            Bunny nqkakvoBunny1 = (Bunny)bunny2;
            Console.WriteLine(nqkakvoBunny.Name);

            //проверява дали това е животно
            if (nqkakvoBunny is Animal)
            {
                Console.WriteLine("I am animal");
            }
        }

    }
}
