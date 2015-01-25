using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo
{
    class Demo
    {
        static void Main(string[] args)
        {
            double a = 0;
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;// разделителя става точка
            Console.WriteLine("{0:F6}", a);//закръгля до шестата цифра след десетичната запетая
        }
    }
}
