using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenomeDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFormat = Console.ReadLine();
            string[] format = inputFormat.Split(' ');
            int lettersPerLine = int.Parse(format[0]);
            int lettersPerSubsequence = int.Parse(format[1]);

            string encodedGenome = Console.ReadLine();
            StringBuilder decodedGenome = DecodeGenome(encodedGenome);
            //Console.WriteLine(decodedGenome);
            PrintFormattedOutput(decodedGenome, lettersPerLine, lettersPerSubsequence);
        }

        static void PrintFormattedOutput(StringBuilder decodedGenome, int lettersPerLine, int lettersPerSubsequence)
        {
            int outputLines = (int)Math.Ceiling((double)decodedGenome.Length / (double)lettersPerLine);
            int maxLineNumberDigits = outputLines.ToString().Length;
            StringBuilder currentFormattedLine = new StringBuilder();  
            int currentIndexDecodedGenome = 0;
            for (int line = 1; line <= outputLines; line++)
            {
                string leadingIntervals = new string(' ', maxLineNumberDigits - line.ToString().Length);//колко цифри има в текущото число
                currentFormattedLine.Append(leadingIntervals);
                currentFormattedLine.Append(line);

                currentIndexDecodedGenome = (line - 1) - lettersPerLine;
                for (int i = currentIndexDecodedGenome; i < lettersPerLine; i++)
                {
                    if (Math.Abs(currentIndexDecodedGenome - i) % lettersPerSubsequence == 0)
                    {
                        currentFormattedLine.Append(' ');
                    }
                    if (i >= decodedGenome.Length)
                    {
                        break;
                    }
                    currentFormattedLine.Append(decodedGenome[i]);
                }

                Console.WriteLine(currentFormattedLine);
                currentFormattedLine.Clear();
            }
        }

        static StringBuilder DecodeGenome(string encodedGenome)
        {
            StringBuilder decodedGenome = new StringBuilder();
            StringBuilder repeatTimesString = new StringBuilder();
            foreach (char symbol in encodedGenome)
            {
                if (symbol == 'A' || symbol == 'C' || symbol == 'G' || symbol == 'T')
                {
                    int repeatTimes = 1;
                    if (repeatTimesString.Length != 0)
                    {
                        repeatTimes = int.Parse(repeatTimesString.ToString());
                        repeatTimesString.Clear();
                    }

                    string genomeSubsequance = new string(symbol, repeatTimes);
                    decodedGenome.Append(genomeSubsequance);
                }
                else
                {
                    repeatTimesString.Append(symbol);
                }
            }
            return decodedGenome;
        }
    }
}
