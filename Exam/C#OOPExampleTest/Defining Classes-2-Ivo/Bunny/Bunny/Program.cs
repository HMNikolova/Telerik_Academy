namespace Bunny
{
    using System;
    using System.Collections;
    using NumeralSystems;
    //ако искам да използвам всичко от папката People, трябва да му допиша
    using NumeralSystems.People;
    using NumeralSystems.People.Students;
    class Program
    {
        public static void Main()
        {
            //за да мога да достъпя полето Fuel, преди това трябва да си създам самолет
            //създавам си нов самолет
            AirCraft boing = new AirCraft();
            //така вече може да достъпя горивото
            boing.Fuel = 100M;

            //създаваме самолет battleCruiser
            AirCraft battleCruiser = new AirCraft();

            Console.WriteLine(boing.Fuel);//100
            Console.WriteLine(battleCruiser.Fuel);//200

            boing.Move();
            //Weight така го достъпваме защото е static
            Console.WriteLine(AirCraft.Weight);

            //така достъпваме classLabrary
            Console.WriteLine(NumeralSystem.ToDesimal(15M, 2));

            Point pt = new Point();
            pt.X = 5;
            pt.Y = 10;

            //добавяме втори конструктор, който да приема параметри
            Point secondPoint = new Point(0,0,0);
            secondPoint.Add(1,2,3);
            //това нещо ни вади 1
            Console.WriteLine(secondPoint.X);
            
            ///може да си извикаме статичния метод така
            Point.Calculate(pt, secondPoint);
        }
    }
}
