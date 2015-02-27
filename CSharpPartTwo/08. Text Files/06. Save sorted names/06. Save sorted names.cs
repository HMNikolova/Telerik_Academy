using System;
using System.IO;
class SaveSortedNames
{
    static void Main()
    {
        //•	Write a program that reads a text file containing a list of strings, sorts them
        //  and saves them to another text file.
       using (StreamReader source = new StreamReader(@"..\..\source.txt"))
        {
            string[] names = File.ReadAllLines(@"..\..\source.txt");
            Array.Sort(names);
            using (StreamWriter target = new StreamWriter(@"..\..\target.txt"))
            {
                for (int i = 0; i < names.Length; i++)
                {
                    target.WriteLine(names[i]);
                }
            }
        }
        }
    }


