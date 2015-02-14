using System;
using System.Collections;
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
            //всеки масив може да изглежда като други типове данни с някои интерфейси
            //Implements ICloneable, IList, ICollection and IEnumerable 
            var arr = new int[5];
            

            //CreateInstance създава обект от тип array
            //долният ред се нарича динамично създаване на обекти и е полезен когато незнаем от какъв тип е масива
            //Array arr = Array.CreateInstance(typeof(int[,]),10);
            //горното е еквивалентно на:
            //int[,] arr = new int[10][10];
            //на Array така се взимат стойностите: arr.GetValue(5,5);,
            //а на масива arr стойностите се взимат: arr[5,5];  

            //int[] oneDim = { 1, 2, 3, 4, 5 };
            //int[,] twoDim = {{1,2,3},
            //                {4,5,6}};
            ////занулява стойностите - в момента сме му дали да занули 4 стойности
            //Array.Clear(twoDim, 0, 4);
            //for (int i = 0; i < twoDim.GetLength(0); i++)
            //{
            //    for (int j = 0; j < twoDim.GetLength(1); j++)
            //    {
            //        Console.Write("{0} ", twoDim[i,j]);
            //    }
            //    Console.WriteLine();
            //}




            //int[] oneDim = { 1, 2, 3, 4, 5 };
            //int[,] twoDim = {{1,2,3},
            //                {4,5,6}};
            ////обръща стойностите на масива
            //Array.Reverse(oneDim);
            //foreach (var num in oneDim)
            //{
            //    Console.WriteLine(num);
            //}


            //int[][] jagged = new int[10][];
            //jagged[0] = new int[]{1,2,3};
            //int[][] jagged2 = new int[2][];
            //Array.Copy(jagged,jagged2,2);
            ////Array.Copy е равносилно да кажа jagged2[0] = jagged[0]; jagged2[2] = jagged[1];   
            //jagged2[0][0] = 123;
            //Console.WriteLine(jagged[0][0]);

            ////copy е метод, който копира част от един масив в друг масив
            //int[] oneDim = { 1, 2, 3, 2, 1 };
            ////връща object, който трябва да кастнем към масив oneDim, който може да присвоим на oneDim2
            //int[] oneDim2 = (int[])oneDim.Clone();
            ////int[] oneDim2 = new int[5];
            ////Array.Copy(oneDim, oneDim2, 5);
            ////искам от oneDim в oneDim2 да копирам 5 стойности
            ////copy е подобно е на .clone, с него се заделя нова памет за 
            ////нов масив а не се прави референция на новия масив
            
            //oneDim2[0] = 123;
            //Console.WriteLine(oneDim[0]);




            //int[] oneDim = { 1, 2, 3 };
            //int[,] twoDim = {{1,2,3},
            //                {4,5,6}};
            //int[][] jagged = new int[10][];
            //foreach (var num in oneDim)
            //{
            //    Console.WriteLine(num);
            //}

            //общ интерфейс за обработване на различни типове данни
            //конструкция foreach в междинния език няма
            //долния код е същия като горния
            //var enumerator = oneDim.GetEnumerator();
            //enumerator.Reset();
            //while (enumerator.MoveNext())
            //{
            //    var num = enumerator.Current;
            //    Console.WriteLine(num);
            //}





            ////деление на каквото и да е число с остатък
            //int n = 10;
            //int[] numbers = { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
            //int[] sizes = new int[n];

            
            //foreach (var number in numbers)
            //{
            //    int remainder = number % n;
            //    sizes[remainder]++;
            //}
            //int[] offsets = new int[n];
            //int[][] numbersByRemainder = new int[n][];
            //for (int i = 0; i < n; i++)
            //{
            //    numbersByRemainder[i] = new int[sizes[i]];
            //}
            ////{ new int[sizes[0]],
            ////    new int[sizes[1]], 
            ////    new int[sizes[2]] };
            //foreach (var number in numbers)
            //{
            //    int remainder = number % n;
            //    int index = offsets[remainder];
            //    numbersByRemainder[remainder][index] = number;
            //    offsets[remainder]++;
            //}

            //for (int row = 0; row < numbersByRemainder.GetLength(0); row++)
            //{
            //    foreach (var num in numbersByRemainder[row])
            //    {
            //        Console.Write(num + " ");
            //    }
            //    Console.WriteLine();
            //}
 



            ////int[] numbers = Enumerable.Range(1, 10).ToArray();
            //int[] numbers = { 3, 5, 4, 6, 12, 2, 3 };
            //int[] counts = new int[3];
            //foreach (var number in numbers)
            //{
            //    int remainder = number % 3;
            //    ++counts[remainder];
            //}
            //int[][] numbersByRemainder = new int[3][]
            //{
            //    new int[counts[0]],
            //    new int[counts[1]],
            //    new int[counts[2]]
            //};

            //int[] indices = new int[3];

            //foreach (var number in numbers)
            //{
            //    int remainder = number % 3;
            //    int position = indices[remainder]; 
            //    numbersByRemainder[remainder][position] = number;
            //    ++indices[remainder];
            //}
          

            //Console.WriteLine(string.Join(", ", numbers));
            //for (int row = 0; row < numbersByRemainder.Length; row++)
            //{
            //    Console.WriteLine("With remainder {0}", row);
            //    for (int col = 0; col < numbersByRemainder[row].Length; col++)
            //    {
            //        Console.WriteLine(numbersByRemainder[row][col]);
            //    }
            //}
            //int[]sizes = new int[3];
            //foreach (var number in numbers)
            //{
            //    int remainder = number % 3;
            //    ++sizes[remainder];
            //    //if (remainder == 0)
            //    //{
            //    //    ++sizes[0];
            //    //}
            //    //else if (remainder == 1)
            //    //{
            //    //    ++sizes[1];
            //    //}
            //    //else if (remainder == 2)
            //    //{
            //    //    ++sizes[2];
            //    //}
            //    int[][] numbersByRemainder = new int[3][];
            //    //numbersByRemainder[0] = new int[sizes[0]];
            //    //numbersByRemainder[1] = new int[sizes[1]];
            //    //numbersByRemainder[2] = new int[sizes[2]];
            //    for (int i = 0; i < numbersByRemainder.Length; i++)
            //    {
            //        numbersByRemainder[i] = new int[sizes[i]];
            //    }
            //    foreach (var number in numbers)
            //    {
            //        int remainder = number % 3;
            //        ++sizes[remainder];
            //        numbersByRemainder[remainder][index] = number;
            //    }
            //}







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
