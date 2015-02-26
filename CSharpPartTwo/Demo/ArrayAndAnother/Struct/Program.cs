using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{

    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point();
            a.X = 5;
            a.Y = 3;
            Console.WriteLine(a.X);
            Console.WriteLine(a.Y);
        }
    }
}
