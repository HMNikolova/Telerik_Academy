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
            //DateTime myBirthDay = new DateTime(1984, 08, 23);
            //int day = myBirthDay.Day;
            ////DateTime other = myBirthDay.AddDays(1.5);
            //TimeSpan other = DateTime.Now - myBirthDay;//TimeSpan връща интервал от време
            //Console.WriteLine(other.Days / 365);//ПОКАЗВА НА КОЛКО ГОДИНИ СИ
            //Console.WriteLine(myBirthDay.TimeOfDay); 
            //DateTime time = DateTime.Now;
            //Console.BackgroundColor = ConsoleColor.Blue;
            //DateTime myTime = new DateTime();
            //Console.WriteLine(time);
            //Console.WriteLine(myTime);


            Car ivosCar = new Car("BMW", "black");//конструктори
            //ivosCar.Name = "BMW";
            //ivosCar.ProductionDate = new DateTime(2010, 1, 1);
            //ivosCar.Color = "black";

            //Car otherCar = ivosCar;
            //otherCar.Name = "ala bala";

            Car nikisCar = new Car("Mazda");
            //nikisCar.Name = "Mazda";
            //nikisCar.ProductionDate = DateTime.Now.AddDays(1);

            Console.WriteLine(ivosCar.Name);
            Console.WriteLine(ivosCar.GetAge());//това ще ни каже, че на Иво колата е на 5 години
            Console.WriteLine(nikisCar.Name);
        }
    }
    public class Car

    {
        public Car(string brand)//снипета на конструктор: ctor
        {
            this.ProductionDate = DateTime.Now;
            this.Name = brand;
        }

        public Car(string brand, string color)
        {
            this.ProductionDate = DateTime.Now;
            this.Name = brand;
            this.Color = color;
        }

        public decimal Price { get; set; }//снипета на обект: prop

        public string Name { get; set; }

        public string Color { get; set; }

        public DateTime ProductionDate { get; set; }

        public int GetAge()
        { 
            int years = (DateTime.Now.Year - this.ProductionDate.Year);
            return years;
        }

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
//get взима дадената стойност
//set поставя дадената стойност