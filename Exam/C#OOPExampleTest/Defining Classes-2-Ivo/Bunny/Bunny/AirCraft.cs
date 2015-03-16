namespace Bunny
{
    using System;
    
    public class AirCraft
    {
        //килограми самолет ги декларираме static
        public static int Weight
        {
            get
            {
                return 250;
            }
        }

        //гориво
        public decimal Fuel { get; set; }

        //създаваме конструктор на самолета
        //ако го запишем така: public AirCraft(int pilot), не можем да създадем самолет без пилот
        //в Program.cs в AirCraft battleCruiser = new AirCraft(1); трябва да има стойност
        public AirCraft()
        {
            //започва с 200
            this.Fuel = 200M;
        }

        //метод Move, който намалява горивото
        public void Move()
        {
            this.Fuel -= 10M;
        }
    }
}
