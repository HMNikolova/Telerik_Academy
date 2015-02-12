using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Enumerable.Range(1, 10).ToArray();
            int[]sizes = new int[3];
            foreach (var number in numbers)
            {
                int remainder = number % 3;
                ++sizes[remainder];
                //if (remainder == 0)
                //{
                //    ++sizes[0];
                //}
                //else if (remainder == 1)
                //{
                //    ++sizes[1];
                //}
                //else if (remainder == 2)
                //{
                //    ++sizes[2];
                //}
                int[][] numbersByRemainder = new int[3][];
                //numbersByRemainder[0] = new int[sizes[0]];
                //numbersByRemainder[1] = new int[sizes[1]];
                //numbersByRemainder[2] = new int[sizes[2]];
                for (int i = 0; i < numbersByRemainder.Length; i++)
                {
                    numbersByRemainder[i] = new int[sizes[i]];
                }
                foreach (var number in numbers)
                {
                    int remainder = number % 3;
                    ++sizes[remainder];
                    numbersByRemainder[remainder][index] = number;
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine(string.Join(", ", sizes));






            //List<List<int>> lists = new List<List<int>>();
            //lists[0][5]

            //int[][] arr = new int[3][];
            //arr[0] = new int[2];
            //arr[1] = new int[4];
            //arr[2] = new int[8];

            //arr[0][1] = 8;
            //arr[2][7] = 7;
            //Console.WriteLine(arr[2][7]);



            //int[][] jagged = new int[3][];
            //jagged[0] = new int[] { 1, 2, 3 };
            //jagged[1] = new int[] { 4, 5 };
            //jagged[2] = new int[] { 6, 7, 8, 9 };
            ////Console.WriteLine("jagged[{0}] [{1}] = {2}", 0,2, jagged [0][2]);
            //for (int row = 0; row < jagged.Length; row++)
            //{
            //    for (int col = 0; col < jagged[row].Length; col++)
            //    {
            //        Console.Write("{0}, ", jagged[row][col]);
            //    }
            //    Console.WriteLine();
            //}


        }
    }
}
