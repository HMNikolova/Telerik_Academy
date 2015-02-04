﻿using System;

public class Fire
{
    public static void Main()
    {

        int N = int.Parse(Console.ReadLine());
         
        for (int i = 1; i <= N; i++)
        {
            Console.Write(new string(':', N / 2 - i));
            Console.Write(':');
            Console.Write(new string(' ', (i - 1) * 2));
            Console.Write(':');
            Console.WriteLine(new string(':', N / 2 - i));
          
        }
       

        // Bottom part of fire
        for (int i = 1; i <= N / 4; i++)
        {
            Console.Write(new string(':', i - 1));
            Console.Write(':');
            Console.Write(new string(':', (N / 2 - i) * 2));
            Console.Write(':');
            Console.WriteLine(new string(':', i - 1));
        }

        // Top part of torch
        Console.WriteLine(new string('-', N));

        // Torch
        for (int i = 1; i <= N / 2; i++)
        {
            Console.Write(new string('.', i - 1));
            Console.Write(new string('\\', N / 2 - (i - 1)));
            Console.Write(new string('/', N / 2 - (i - 1)));
            Console.WriteLine(new string('.', i - 1));
        }
        //int N = int.Parse(Console.ReadLine());
        //Console.WriteLine(new string(':', N));
        //Console.Write(':');
        //Console.Write(' ', N / 2);
        //Console.Write(':');
        //Console.Write(new string(' ', (i - 1) * 2));
        //Console.Write(':');
        //Console.WriteLine(new string(':', N / 2 - i));
    }
}