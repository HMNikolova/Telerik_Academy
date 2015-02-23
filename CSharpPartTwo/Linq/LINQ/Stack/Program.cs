using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var stack = new Stack<int>();
        stack.Push(1);//push е същото като add, защото в stack няма add
        stack.Push(5);
        stack.Push(10);
        Console.WriteLine(stack.Count);
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        //Peek погледни без да го вадиш от колекцията, докато Pop вади от колекцията
        int nextNum = stack.Peek();
        Console.WriteLine(nextNum);
        Console.WriteLine(stack.Count);//и ако ги преброим пак са 3 елемента в колекцията

        //за да видим реда на вкарване
        int nextNumber = stack.Pop();//Pop ни вади последния вкаран
        Console.WriteLine(nextNumber);

        nextNumber = stack.Pop();
        Console.WriteLine(nextNumber);
        Console.WriteLine(stack.Pop());


    }
}