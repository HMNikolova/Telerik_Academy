using System;

public class Program
{
    //пример как може да използваме stack
    //т.е. със stack се контролира извикването на методи и връщането му
    //обратно до там докъдето сме били
    static void Print()
    {
        Console.WriteLine(GetValue());
    }

    static int GetValue()
    {
        return 5;
    }

    public static void Main()
    {
        Print();
    }
}