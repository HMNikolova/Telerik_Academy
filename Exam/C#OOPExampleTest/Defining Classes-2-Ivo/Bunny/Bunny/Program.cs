namespace Bunny
{
    using System;
    using System.Collections;
    
    using NumeralSystems;
    //ако искам да използвам всичко от папката People, трябва да му допиша
    using NumeralSystems.People;
    using NumeralSystems.People.Students;
    //собствени using-ги, ако имаме еднакви имена на класове
    //using BaiPesho =  Bunny.People.Pesho;
    
    class Program
    {
        public static void Main()
        {
            //и ако му кажа BaiPesho то се сеща, кой клас да си ползва
            //BaiPesho baiPesho = new BaiPesho();
            
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
            
            //шаблонен тип или generic тип
            //в зависимост какъв тип му подам самия клас работи с такъв тип
            //List<int> listOfIntegers = new List<int>();
            //List<string> listOfStrings = new List<string>();
        }
    }
}
