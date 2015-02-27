using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        var reader = new StreamReader(@"..\..\file.txt");
        var writer = new StreamWriter(@"..\..\output.txt");
        //var reader = new StreamReader("file.txt", Encoding.UTF8);//ако искаме кирилица
        //string text = reader.ReadToEnd();//връща ни цялото съдържание на файла
        //string secondLine = reader.ReadLine();//може да четем ред по ред особено ако е голям файла
        //Console.WriteLine(text + secondLine);
        //Console.WriteLine(text);
        //reader.Close();//затваряме StreamReader

        //по-лесният начин за затваряне на файлове
        using (reader)
        {
            //string text = reader.ReadToEnd();
            //string secondLine = reader.ReadLine();
            //Console.WriteLine(text + secondLine);

            //четене ред по ред
            string currentLine = reader.ReadLine();
            int count = 1;

            using (writer)
            {
                while (currentLine != null)//прехвърляне в друг файл
                {
                    writer.WriteLine("{0:D2}. {1}", count, currentLine);
                    count++;
                    currentLine = reader.ReadLine();
                }
            }

            //while(currentLine != null)//докато currentLine е различно от null
            //{
            //Console.WriteLine("{0}. {1}", count, currentLine);
            //count++;
            //currentLine = reader.ReadLine();//чети ми нова линия
            //}
        }

        //var writer = new StreamWriter("numbers.txt");
        using (writer)
        {
            for (int i = 0; i < 1000; i++)
            {
                writer.WriteLine(i);
                //writer.Write(i + " ");
            }
        }
    }
}