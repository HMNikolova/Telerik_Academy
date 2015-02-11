using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {


            int[, ,] cube = new int[3, 4, 5];

            string result = string.Empty;
            {
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        for (int z = 0; z < 5; z++)
                        {
                            cube[x, y, z] = x * y * z;
                        }
                    }
                }
                
            }
            Console.WriteLine("Cell at [1,2,3]: {0}", cube[1, 2, 3]);
            Console.WriteLine("Last cell: {0}", cube[2,3,4]);

        }
    }

}