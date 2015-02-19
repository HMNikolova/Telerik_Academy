using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            Console.BackgroundColor = ConsoleColor.Blue;
            DateTime myTime = new DateTime();
            Console.WriteLine(time);
            Console.WriteLine(myTime);

            
            Car ivosCar = new Car();
            ivosCar.Name = "BMW";
            ivosCar.ProductionDate = DateTime.Now;
            ivosCar.Color = "black";

            Car otherCar = ivosCar;
            otherCar.Name = "ala bala";

            Car nikisCar = new Car();
            nikisCar.Name = "Mazda";
            nikisCar.ProductionDate = DateTime.Now.AddDays(1);

            Console.WriteLine(ivosCar.Name);
            Console.WriteLine(nikisCar.Name);
        }
    }
    public class Car
    {
        public decimal Price { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public DateTime ProductionDate { get; set; }

    }
}

//System.Console
//System.String (string in C#) - String е самия клас, а string е ключова дума,
//което казва, ако някой извика string, ходи и извикай този клас String
//System.Int32 (int in C#)
//System.Array
//System.Math
//System.Random
//System.DateTime
//System.Collections.Generics.List<T>
