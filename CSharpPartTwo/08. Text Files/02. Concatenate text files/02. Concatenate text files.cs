using System;
using System.IO;
class ConcatenateTextFiles
{
    static void Main()
    {
        //•	Write a program that concatenates two text files into another text file.
        using (StreamWriter write = new StreamWriter(@"..\..\concatenatedTest.txt", true))
        {
            using (StreamReader firstReader = new StreamReader(@"..\..\firstTest.txt"))
            {
                string line = firstReader.ReadLine();
                while (line != null)
                {
                    write.WriteLine(line);
                    line = firstReader.ReadLine();
                }
            }

            using (StreamReader secondReader = new StreamReader(@"..\..\secondTest.txt"))
            {
                string line = secondReader.ReadLine();
                while (line != null)
                {
                    write.WriteLine(line);
                    line = secondReader.ReadLine();
                }
            }
        }

        Console.WriteLine("Concatenation is done.");
    }
}
