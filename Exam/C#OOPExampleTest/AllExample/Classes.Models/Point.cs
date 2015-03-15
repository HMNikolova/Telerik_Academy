namespace Classes.Models
{
    using Classes.Models.Interfaces;
    using Classes.Models;
    using System;

    //public class Point//class-овете са референтни типове
    //тук трябва да напишем Point може да се сравни с Point и върху IComparable ни се появява отдолу тикче да ни подсети да си направим такъв метод
    public struct Point : IComparable<Point>
    {
        //public Point(int x, int y)
        public Point(int x, int y) : this()//при struct
        {
            this.X = x;
            this.Y = y;

        }

        public int X { get; set; }

        public int Y { get; set; }

        //презаписване по какъв начин работи даден метод
        public override string ToString()
        {
            return string.Format("{0}, {1}", this.X, this.Y);
        }

        public int CompareTo(Point other)
        {
            //сравняваме го до 0, моята точка ли е по отдалечена от 0 или другата 
            double distThisPoint = Math.Sqrt(this.X * this.X + this.Y * this.Y);
            double distOtherPoint = Math.Sqrt(other.X * other.X + other.Y * other.Y);
            //върни ми положително, ако моята точка е < ми върни -1
            return distThisPoint > distOtherPoint ? 1 : -1;

            //ако моята точка в момента е с по-голям Х, ще ми върне положително 
            //return this.X - other.X;
        }
    }
}
