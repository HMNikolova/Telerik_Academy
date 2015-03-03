using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialValue
{
    class Program
    {
        static int[][] ReadData(int[][] field)// да му се подава масив, който ще бъде запълнен
        {
            //имаме 4 реда, на всеки трябва да направи като за начало Console.ReadLine()
            //да го сплитнем по интервал и запетая
            for (int i = 0; i < field.GetLength(0); i++)//GetLength защото е двумерен
            {
                //т.е. за всеки ред трябва да прочетем нашите числа
                string[] cuurentLine = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);//разцепва ни текущата линия на числа представени като стрингове 
                //записваме текущия ред в нашия назъбен масив; назъбения масив трябва да се инициализира ред по ред
                field[i] = new int[cuurentLine.Length];//т.е. текущия ред = на дълвината му
                //на всеки ред от назъбения масив трябва да му инициализираме друг масив, а колко е дължината на този друг масив, ами колкото е дължината на масива от стринговете
                //попълваме колоните
                for (int l = 0; l < cuurentLine.Length; l++)
                {
                    field[i][l] = int.Parse(cuurentLine[l]);
                }
            }
            return field;
        }

        static long FindCurrentSpecialValue(int[][] field, int column, bool[][] used)//подаваме му полето, текущата колона, от която да тръгне и му подаваме масива used да знае какво да прави с него
        {
            long result = 0;//краен резултат, който да върнем
            int currentRow = 0;//на кой ред сме
            //резултата трябва да го наливаме някъде

            for (int i = 0; i < used.GetLength(0); i++)//зануляваме реда с flse-ове
            {
                used[i] = new bool[field[i].Length];
            }

            while (true)
            {
                result++;//трябва и резултаата при всяка стъпка да го увеличаваме
                if (used[currentRow][column])//дали текущото поле е посетено, на текущия ред от column
                {//ако е посетено и върне true
                    return long.MinValue;//като върнем отрицателна стойност тя винаги ще е по-малка от която и а е друга пътека и няма да изгубим максималната пътека
                }
                if (field[currentRow][column] < 0)//в полето от текущия ред и текущата колона имаме число по-малко от 0, към резултата трябва да добавим абсолютната стойност на това числото, което сме достигнали
                {//ситуация, в която трябва да върнем стойност, когато имаме отрицателно число
                    result -= field[currentRow][column];
                    return result;
                }

                int nextColumn = field[currentRow][column];//щом не е отрицателно и не е посетено
                used[currentRow][column] = true;//трябва да отбележим, че сме го посетили  
                column = nextColumn;

                currentRow++;//след всяка интерация този row да го увеличаваме

                if (currentRow == field.GetLength(0))//ако нашия ред излезе от редовете трябва да се върне на 0-та
                {
                    currentRow = 0;
                }
            }
        }

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            //назъбен масив
            int[][] field = new int[N][];//казваме му, че искаме n на брой редове
            
            ReadData(field);
            
            bool[][] used = new bool[N][];//по default е пълен с false-ове, т.е., че от тук не сме минали

            for (int i = 0; i < N; i++)//ЗА ВСЕКИ РЕД ДА ИНИЦИАЛИЗИРА ПО ЕДИН МАСИВ, КОЙТО Е РАВЕН НА ДЪЛЖИНАТА НА ГОРНИЯ МАСИВ с име field
            {
                used[i] = new bool[field[i].Length];
            }

            long max = long.MinValue;//max стойност
            
            //обикаля на първия ред всички колони, да извиква метода и да получава, каквото трябва да получи
            for (int i = 0; i < field[0].Length; i++)
            {
                long specialValue = FindCurrentSpecialValue(field,i,used);//на метода първо му трябва поле - подаваме му, после колона - подаваме му, след това иска масив подаваме му used
                //търсиме max стойност
                if (max < specialValue)
                {
                    max = specialValue;
                }
            }
            Console.WriteLine(max);

        }
    }
}
