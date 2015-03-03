using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TwoGirlsOnePath
{
    class Program
    {
        static void Main(string[] args)
        {
            //въртиме един for цикъл да ни split-не, въртим втори for цикъл, за да ни ги парсне, и трети for цикъл, за да ни се копира едното нещо в друг масив
            BigInteger[] numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            int mollyIndex = 0;
            int dollyIndex = numbers.Length - 1;

            BigInteger mollyTotalFlowers = 0;
            BigInteger dollyTotalFlowers = 0;

            string winner = string.Empty;

            while (true)//да разберем кога спира
            {
                if (numbers[mollyIndex] == 0 && numbers[dollyIndex] == 0)
                {
                    winner = "Draw";
                }
                else if (numbers[mollyIndex] == 0)
                {
                    winner = "Dolly";
                }
                else if (numbers[dollyIndex] == 0)
                {
                    winner = "Molly";
                }
                
                if (numbers[mollyIndex] == 0 || numbers[dollyIndex] == 0)
                {
                    mollyTotalFlowers += numbers[mollyIndex];
                    dollyTotalFlowers += numbers[dollyIndex];//прибавяме текущия индекс към крайния резултат
                    break;//спира, когато една от двете стъпи на празен индекс
                }

                BigInteger currentMollyFlowers = numbers[mollyIndex];//събиране на цветя
                BigInteger currentDollyFlowers = numbers[dollyIndex];//трябват ни две променливи, за двете момичета 

                if (mollyIndex == dollyIndex)
                {
                    numbers[mollyIndex] = currentMollyFlowers % 2;//тук оставяме 0 или 1 в зависимост дали е четно или нечетно
                    mollyTotalFlowers += currentMollyFlowers / 2;
                    dollyTotalFlowers += currentDollyFlowers / 2;
                }
                else
                {
                    //след като съберем цветята трябва да ги изтрием от масива, ако пак се стъпи на този индекс се излиза от игра
                    numbers[mollyIndex] = 0;
                    numbers[dollyIndex] = 0;

                    mollyTotalFlowers += currentMollyFlowers;
                    dollyTotalFlowers += currentDollyFlowers;
                }
                

                mollyIndex = (int)((mollyIndex + currentMollyFlowers) % numbers.Length);
                dollyIndex = (int)((dollyIndex - currentDollyFlowers) % numbers.Length);
                if (dollyIndex < 0)
                {
                    dollyIndex += numbers.Length;
                }
            }
            Console.WriteLine(winner);
            Console.WriteLine("{0} {1}", mollyTotalFlowers, dollyTotalFlowers);
        }
    }
}
