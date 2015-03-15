namespace Bunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AirCraft
    {
        //метод, който изчислява резстоянието между два AirCraft
        public static double CalculateDistance(AirCraft first, AirCraft second)
        {
            double xDistance = (first.Coordinates.X - second.Coordinates.X) * (first.Coordinates.X - second.Coordinates.X);
            double yDistance = (first.Coordinates.Y - second.Coordinates.Y) * (first.Coordinates.Y - second.Coordinates.Y);
            return Math.Sqrt(xDistance + yDistance);

        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Damage { get; set; }//с толкова точки атакуваме

        public Bunny Pilot { get; private set; }

        //координти на самолета
        public Coordinates Coordinates { get; private set; }

        //конструктор - самолет със зайци
        public AirCraft(Bunny bunny, int damage)//int damage казва колко да е силен(атака) AirCraft-а
        {
            this.Pilot = bunny;
            this.Damage = damage;
            this.Coordinates = new Coordinates();//първоначално всички кораби са на 0-та
        }


        public void Attack(AirCraft target)
        {
            //ако са от един цвят да не се атакуват
            if (this.Pilot.Color == target.Pilot.Color)
            {
                return;
            }
            //на този target, който ние подаваме, му взимаме пилота и неговата кръв и да намалим с колко ни е атакувал
            target.Pilot.Health -= this.Damage;
        }

        public void Move(Coordinates coor)//КОГАТО ИЗВИКАМ МЕТОДА аз трябва да дам нови координати на които премествам кораба
        {
            //хваща координатте на текущия кораб
            this.Coordinates.X = coor.X;
            this.Coordinates.Y = coor.Y;
        }


    }
}