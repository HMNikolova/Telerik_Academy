using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRES4Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeralSystem = 9;
            var digit = new[] {"LON+", "VK-", "*ACAD", 
                "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", 
                "<<DON"};
            ulong numberInDecimal = ulong.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();

            do
            {
                int digitIn9th = (int)(numberInDecimal % (ulong)numeralSystem);
                result.Insert(0, digit[digitIn9th]);
                numberInDecimal /= (ulong)numeralSystem;
            }
            while (numberInDecimal > 0);
            Console.WriteLine(result.ToString());
        }
    }
}
