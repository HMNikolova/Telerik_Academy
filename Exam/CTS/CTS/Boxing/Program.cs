using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        //извикваме го по референция
        public static void SomeNumberChange(ref int number)
        {
            number += 100;
        }


        ////искам да изкарам още нещо от самия метод
        //public static int InitializeNumber(int number, out int result)
        //{
        //    result = number + 5;
        //    return number;
        //}

        //public static void ChangeDateObject(object date)
        //{
        //    DateTime dateAsDate = (DateTime)date;
        //    dateAsDate.AddDays(1);
        //}

        static void Main(string[] args)
        {
            int number = 5;
            SomeNumberChange(ref number);
            Console.WriteLine(number);

            //int number = 1;
            //int result;
            //int resultFromMethod = InitializeNumber(number, out result);
            //Console.WriteLine(result);
            //Console.WriteLine(resultFromMethod);

            //DateTime now = DateTime.Now;

            ////int now = 5;
            //object numberAsObj = now;

            //ChangeDateObject(numberAsObj);
            //now = (DateTime)numberAsObj;
            //Console.WriteLine(now.Day);
        }

        
    }
}
