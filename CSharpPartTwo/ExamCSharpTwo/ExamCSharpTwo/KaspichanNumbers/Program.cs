using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspichanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //array of 256 elements
            ulong baseNum = 256;
            string[] arr = GenerateNumber(256);
            //for (int i = 0; i <= 'j' - 'a'; i++)
            //{
            //    for (int j = 0; j < 26; j++)
            //    {
            //        if (i == 0)
            //        {
            //        arr[i + j] = ((char)(j + 'A')).ToString();
            //        }
            //        else
            //        {
            //            arr[i * 26 + j] = string.Format("{0}{1}", (char)(i - 1 + 'a'), (char)(j + 'A'));
            //        }
            //    }
            //}

            //read input
            ulong input = ulong.Parse(Console.ReadLine());

            //calculations
            string result = string.Empty;
            if (input == 0)
            {
                result = "A";
            }
            else{
            while (input > 0)
            {
                ulong index = input % baseNum;
                result = arr[index] + result;
                input /= baseNum;
            }
        }
            //output
            Console.WriteLine(result);
        }

        private static string[] GenerateNumber(int numBase)
        {
            string[] arr = new string[numBase];
            for (int i = 0; i < numBase; i++)
            {
                if (i < 26)
                {


                    arr[i] = string.Format("{0}", (char)(char)(i + 'A'));
                }
                else
                {
                    arr[i] = string.Format("{0}{1}", (char)(i / 26 - 1 + 'a'), (char)(i % 26 + 'A'));
                }
            }
            return arr;
        }
    }
}
