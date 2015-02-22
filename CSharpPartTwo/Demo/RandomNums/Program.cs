using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNums
{
    class Program
    {
        static Random rand = new Random();

        static void Main()
        {
            for (int number = 0; number < 32; number++)
            {
                int randomNumber = GetRandomNumber();
                Console.WriteLine(randomNumber);
            }
        }
        private static int GetRandomNumber()//без параметър параметър
        {
            int num = rand.Next(100, 200);
            return num;
        }


        //Random rand = new Random();
        //for (int number = 1; number <= 6; number++)
        //{
        //    int randomNumber = rand.Next(49) + 1;
        //    Console.WriteLine("{0} ", randomNumber);
        //}


        //    Random rand = new Random();
        //    for (int number = 0; number < 32; number++)
        //    {
        //        int randomNumber = GetRandomNumber(rand);
        //        Console.WriteLine("{0} ", randomNumber);
        //    }
        //}
        //private static int GetRandomNumber(Random rand)//с параметър
        //{
        //    int num = rand.Next(100,200);
        //    return num;
        //}
        
    }
}
