
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EncodingSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            string n = Console.ReadLine();
            string input = " ";
            int number = int.Parse(input);
            int unicode = 65;
            char character = (char)unicode;
            string text = character.ToString();
            int current = 0;
            char c = ' ';
            int result = 0;
            string texts = "0 a+…”";
            foreach (char ce in text)
            {
                Console.WriteLine("{0} U+{1:x4} {2}", ce, (int)ce, (int)ce);
                result = ce % m;
            }

            for (int i = 0; i < current; i++)
            {
               
                if (c == '@')
                {

                    break;
                }
                else if (current > 0 && current < 9)
                {
                    result *= current;
                }
                
                else
	            {
                    string sub = input.Substring(0, 1);
                    
                    Console.WriteLine("{0}", sub);
                    result += number;
	            }
            }
            
            
            
                Console.WriteLine(result);
            }




    }
    }







