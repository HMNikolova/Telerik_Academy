using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiverseCommunication
{
    class Program
    {
        //тринадесетична бройна система
        static void Main(string[] args)
        {
            var alphabet = new List<string> { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };//имаме масив от букви в инпровизираната бройна система 
            //прочитаме входа и го разделяме на тройки символи
            var input = Console.ReadLine();

            long decimalRepresentation = 0;
            for (int i = 0; i < input.Length; i += 3)//на всяка стъпка в цикъла да прескача по 3 символа
            {
                //променлива digit в тринадесетична бройна система
                var digit13 = input.Substring(i, 3);//започва от i и взима по три сивмола
                //десетичното число, на която тази цифра отговаря
                //ако беше масив трябваше да е Array.IndexOf
                var decimalValue = alphabet.IndexOf(digit13);//по даден елемент в съответния списък ми дава индекса, на който той се намира, в случая, ако му подам "TEL" ще ми върне 1; И това е десетичната стойност на числото
                decimalRepresentation *= 13;//умножаваме по 13, защото работим с тринадесетична бройна система
                decimalRepresentation += decimalValue;//прибавяме десетичната стойност
            }
            Console.WriteLine(decimalRepresentation);
            //тестваме максималния възможен вход: 9 пъти PLAPLAPLAPLAPLAPLAPLAPLAPLA
            //сменяме променливата върху, която натрупваме на long


            //var input = Console.ReadLine();
            //алгоритъм за преобразуване от една бройна система в друга
            //var hex = "FAB1";
            //var decimalRepresentation = 0;
            //for (int i = 0; i < hex.Length; i++)//за всяка цифра от шестнадесетичното число
            //{
            //    //взимам десетичното число и го умножавам по бройната система, с която работя
            //    decimalRepresentation *= 16;
            //    if (hex[i] >= '0' && hex[i] <= '9')//ако съответната цифра от шестнадесетичната бройна система е между 0 и 9
            //        {
            //            //прибавям към числото десетичното представяне на цифрата от съответната бройна система
            //            decimalRepresentation += hex[i] - '0';// hex[i] - '0' - ще ни го обърне в цифра за 0 - 0 за 8 - 8
            //        }
            //    else
            //    {
            //        decimalRepresentation += hex[i] + 10 - 'A';//това ще ни обърне буквите в цифри съответно 10,11,12,13,14,15
            //    }
            //}
            //Console.WriteLine(decimalRepresentation);
        }
    }
}
