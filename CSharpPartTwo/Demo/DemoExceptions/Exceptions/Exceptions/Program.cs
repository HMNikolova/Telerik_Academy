using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int result = 10 / a;
            }
            catch (FormatException)
            {

                Console.WriteLine("Input is not digit!");
            }
            catch (DivideByZeroException)
            {
                //Console.WriteLine("You cannot enter zero!");
                //Console.WriteLine(ex.Message);//Message - показва типа на грешката
                //Console.WriteLine(ex.StackTrace);//StackTrace - в кой метод е гръмнал exception
            }
        }
    }
}
