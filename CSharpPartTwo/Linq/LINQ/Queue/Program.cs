using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        //опашката работи по същия начин като стека, 
        //но с разликата, който пръв се нареди, той пръв излиза

        var queue = new Queue<int>();
        queue.Enqueue(5);//така добавяме
        queue.Enqueue(6);
        queue.Enqueue(7);
        queue.Enqueue(8);
        //Console.WriteLine(queue.Dequeue());//така излиза от опашката
        //Console.WriteLine(queue.Dequeue());

        //алгоритъм, който вади всички елемети от опашката
        //while(true)
        //{
        //if(queue.Count == 0)
        //{
        //break;
        //}
        //Console.WriteLine(queue.Dequeue());
        //}
        //другият вариант 
        while (queue.Count != 0)
        {

            Console.WriteLine(queue.Dequeue());
        }
    }
}