using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2 - i - 1; j++)
                {
                    Console.Write('.');
                }
                Console.Write('#');
                for (int j = 0; j < i * 2; j++)
                {
                    Console.Write('.');
                }
                Console.Write('#');
                for (int j = 0; j < n / 2 - i - 1; j++)
                {
                    Console.Write('.');
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n / 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('.');
                }
                Console.Write('#');
                for (int j = 0; j < n - i - i - 2; j++)
                {
                    Console.Write('.');
                }
                Console.Write('#');
                for (int j = 0; j < i; j++)
                {
                    Console.Write('.');
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();

            for (int row = 0; row < n / 2; row++)
            {
                for (int i = 0; i < row; i++)
                {
                    Console.Write('.');
                }
                //вмсто горния цикъл може да се ползва: Console.Write(new string('.', row)); 
                for (int i = 0; i < n / 2 - row; i++)
                {
                    Console.Write('\\');
                }

                for (int i = 0; i < n / 2 - row; i++)
                {
                    Console.Write('/');
                }

                for (int i = 0; i < row; i++)
                {
                    Console.Write('.');
                }

                Console.WriteLine();
            }
        }
    }

