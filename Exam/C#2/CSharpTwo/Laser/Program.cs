﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Laser
{
    class Program
    {
        static void Main(string[] args)
        {
            //ако съществува файлът input.txt в нашата папка на директорията
            if (File.Exists("input.txt"))
            {
                Console.SetIn(new StreamReader("input.txt"));//вместо от конзолата ще четем от него
            }
            //първите числа, които ще четем от конзолата, това са размерите на куба
            int[] dims = GetThreeNumbersFromConsole();
            //вторите числа са началните позиции
            int[] pos = GetThreeNumbersFromConsole();
            //третите числа са посочения вектор
            int[] vect = GetThreeNumbersFromConsole();//отместването в x,y,z след всеки вход

            //посетени и непосетени полета
            bool[,,] visited = new bool[dims[0] + 1, dims[1] + 1, dims[2] + 1];//масив от три измерения, понеже първият елемент не е 0, а е 1 в трите измерения, 
            //си правим таблицата с + 1 за всяко измерение, за да имаме място да пазим и индексите както са в задачата, за да не се налага всеки път когато индексираме да вадим или прибавяме 1

            while (true)
            {
                visited[pos[0], pos[1], pos[2]] = true;//отбелязваме в таблицата, че позицията вече е посетена
                //правим си нова точка с целочислени координати
                int[] newPos = new int[3];//чрез vect можем да сметнем следващата позиция
                for (int i = 0; i < 3; i++)//новата позиция е базирана на сегашната позиция с отместването
                {
                    newPos[i] = pos[i] + vect[i];//всеки от компонентите на новата позиция е равен на предишната позиция плюс отместването
                    //т.е. ако предишния ход сме били на позиция 2,2,2, а вектора за отместването ни е 1,0,-1 следващия ход резултата става 3,2,1 или
                    //pos: (2,2,2)
                    //vect: (1,0,-1)
                    //newPos: (3,2,1)//новата позиция е с тези координати
                }
                    //дали позицията е посетена или дали сме стигнали до някой от ръбовете на куба
                    if (visited[newPos[0], newPos[1], newPos[2]] ||
                        HowManyIndexesAreLimit(newPos, dims) >= 2)
                    {
                        Console.WriteLine("{0} {1} {2}", pos[0], pos[1], pos[2]);//изкарваме си полето, на което сме в момента, защото то е последното поле, на което сме били преди края на програмата
                        return;
                    }

                    //проверка дали сме стигнали до стена, стените са тези кубчета, в които един от координатите е 0
                    //подаваме позицията за която питаме и размерите на куба
                    if (HowManyIndexesAreLimit(newPos, dims) == 1)//ако е равно на 1 сме стигнали до стена
                    {//трябва да намерим, кой от трите индекса води до излизане от стената
                        //(2,0,1) - 0 значи че сме стигнали до стената, на която отговаря втория компонент
                        //(1,-1,1) - ако ги съберем става (3,-1,2) - и ще сме излезли от куба, значи трябва да обърнем втория компонент
                        ReverseComponent(newPos, vect, dims);
 
                        //ако е равно на 2 сме стигнали до ръб
                        //ако е равно на 1 сме стигнали точно до ъгълчето на куба
                    }
                    //след всяка интерация трябва да кажем, че сегашната позиция е новата позиция
                    for (int i = 0; i < 3; i++)
                    {
                        pos[i] = newPos[i];
                    }
                    
                
            }
        }

        static void ReverseComponent(int[] newPos, int[] vect, int[] dims)
        {
            //откриване на проблемния компонент
            for (int i = 0; i < 3; i++)//обхождаме си позицията
            {
                if (newPos[i] == 1 && vect[i] == -1)//ако позицията има компонент 0 т.е. 1, вектора има компонент -1 т.е. векторът ни кара да изпизаме откъм отрицателната страна т.е. на следващия ход този компонент ще стане 0 ще излезем извън куба
                {
                    //затова обръщаме компонентата
                    vect[i] *= -1;
                }
                else if (newPos[i] == dims[i] && vect[i] == 1)//ако компонентата е равна на размера на куба и компонентата на вектора е положителен
                {
                    //значи вектора ни кара да излизаме от положителната посока и пак обръщаме вектора
                    vect[i] *= -1;
                }
            }
        }
        
        static int HowManyIndexesAreLimit(int[] pos, int[] dims)//колко от индексите са на края на куба
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                if (pos[i] == 1 || pos[i] == dims[i])//ако е 1 или е равен на размера увеличаваме с едно
                {
                    count += 1;
                }
            }
            return count;
        }

        static int[] GetThreeNumbersFromConsole()//помощен метод връща масив от 3 int-a
        {
            string input = Console.ReadLine();//взимаме си низ от консолата
            string[] split = input.Split(' ');//разделяме го на интервалите
            return split.Select(s => int.Parse(s)).ToArray();//получаваме масив от три низа, като всеки от тези низове ще ги пъхнем през функцията int.Parse и накрая това го превръщаме в масив
            //долните 6 реда са еквивалентни на горния 1 ред
            //int array = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    array[i] = int.Parse(split[i]);
            //}
            //return array;
        }
    }
}