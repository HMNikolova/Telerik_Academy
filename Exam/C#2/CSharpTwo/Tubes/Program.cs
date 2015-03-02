using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes
{
    class Program
    {
        static void Main(string[] args)
        {
            //задачата се решава с двойчно търсене, т.е. опитваме се да налучкаме отговора на задачата
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] tube = new int[n];
            int left = 0;//лява граница
            int right = 0;//дясна граница
            int mid = 0;
            for (int i = 0; i < n; i++)
            {//четем n на брои тръби и ги записваме в един масив
                tube[i] = int.Parse(Console.ReadLine());
                if (right < tube[i])
                {
                    right = tube[i];//дясната ни граница е най-голяма измежду тръбите - намираме най-голямата измежду всички тръби и това ни е дясна граница
                }
            }
            mid = (left + right) / 2;//средата е лявата и дясната граница делено на 2
            int maxTube = -1, eventualTubes = 0;
            while (left <= right)//докато лявата граница е <= на дясната граница
            {
                eventualTubes = 0;
                for (int i = 0; i < n; i++)
                {
                    eventualTubes += tube[i] / mid;//целочислено деление на всяка от размера на тръбите
                    //започваме да смятаме колко на брой тръби можем да отрежем с mid, който е нашият кандидат за отговор
                }
                if (eventualTubes >= m)//проверяваме те по-голями или равни ли са на броя тръби, който искаме
                {
                    left = mid + 1;
                    maxTube = mid;
                }
                else//ако тези тръби не са ни достатъчни
                {
                    right = mid - 1;//тогава по-голямите отговори няма да стават
                }
                mid = (left + right) / 2;//тогава делим средата на 2
            }
            Console.WriteLine(maxTube);
        }
    }
}
