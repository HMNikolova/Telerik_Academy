namespace ClassesDemo
{
    using Classes.Models.Interfaces;
    using Classes.Models;
    using System;
    using System.Collections.Generic;
    //ако имаме два класа с едно и също име и стане конфликт може да го решим по следния начин
    //using Point2D = Classes.Models.Point;

    class Program
    {
        public static void Main()
        {
            CustomStack<Point> stackOfPoints = new CustomStack<Point>();//ползваме го за метода Push с произволен брой елементи в масив
            //IStack<Point> stackOfPoints = new CustomStack<Point>();
            IStack<int> stackOfints = new CustomStack<int>();

            //за да работи //IStack<Point> stackOfPoints = new CustomStack<Point>(); при stackOfPoints.Push(new Point(2, 3), new Point(2, 3), new Point(2, 3), new Point(2, 3), new Point(2, 3));
            //трябва да добавим в IStack(самия интерфейс) void Push(params T[] element) за да го задължа той да има такъв метод и тогава щеше да работи

            stackOfPoints.Push(new Point(2, 3), new Point(2, 3), new Point(2, 3), new Point(2, 3), new Point(2, 3));//увеличаване на Capacity * 2, но и винаги може да увеличим константата от 4 примерно на 16 - private const int InirialLenght = 4;
            stackOfPoints.Push(new Point(2, 3));
            stackOfPoints.Push(new Point(2, 3));

            //Pop
            stackOfPoints.Push(new Point(1, 1),
                new Point(2, 2),
                new Point(3, 3),
                new Point(4, 4),
                new Point(5, 5));
            //вътрешно ще си извика tostring метода на дадения тип
            Point point = stackOfPoints.Pop();//на тази стъпка ни маха от стека точката 5,5
            Console.WriteLine(point);
            stackOfPoints.Push(new Point(6, 6));
            stackOfPoints.Push(new Point(7, 7));
            Console.WriteLine(stackOfPoints.Pop());//по същия начин си махаме точката 7,7
            Console.WriteLine(stackOfPoints.Pop());//още един път ако поискаме да ни извади последния елемент ни вади 6,6

            //за да мога да използвам Point, отивам в класа, където е създадена Point
            int res = Comparer<Point>(stackOfPoints.Pop(), stackOfPoints.Pop());
            Console.WriteLine(res);

            //да работим с повече типове
            //int res1 = Comparer1<Point, int, string>(stackOfPoints.Pop(), stackOfPoints.Pop());
            //Console.WriteLine(res1);

            Dictionary<int, string> dict = new Dictionary<int, string>();

            ////Point p1 = new Point(2, 4);//(в struct,а не в class) остава си 2,4, тъй като когато аз подавам стойностен тип(int,double...) тяхната стойност се копира, т.е. когато влезна в метода CalculateDistance   
            //Point p1 = new Point(2, 4);//при class стойността се променя на 10, метода променя стойността, тъй като това е референтен тип
            //Point p2 = new Point(3,6);
            //double dist = CalculateDistance(p1, p2);
            //Console.WriteLine(dist);
        }
        //сравняваме две точки, IComparable ще ни задължи на мястото на Т аз да мога да ползвам само такива типове, които наследяват IComparable
        public static int Comparer<T>(T first, T second) where T : IComparable<T>
        {
            //когато използвам IComparable се задължавам да използвам метода CompareTo
            //като CompareTo се прилага върху някакъв(сегашния) елемент и му подавам втори елемент, с който той ще го ставни
            return first.CompareTo(second);//това нещо връща int
            
        }

        //първия аргумент ще е от тип Т1, втория ще е от тип Т2
        //public static int Comparer1<T1, T2, T3>(T1 first, T2 second) 
        //    where T1 : IComparable<T1>
        //    where T2 : IEquatable<T2>
        //{
        //    return first.CompareTo(second);
        //}



        //private static double CalculateDistance(Point p1, Point p2)
        //{
        //    p1.X = 10;
        //    return 0.0;
        //}

        ////private static double CalculateDistance(Point p1, Point p2)//тук вече работя с друга променлива, не е абсолютно същата, която има същата стойност и стойността се копира
        ////{
        ////    p1.X = 10;//ако променим тази точка няма да се промени първоначалната
        ////    return 0.0;
        ////}
    }
}
