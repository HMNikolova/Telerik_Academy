using System;

public class Program
{
    public static void StringManipulation(string text)
    {
        if (string.IsNullOrWhiteSpace(text))//ако текста е Null или само спейсове и табулации, това ще върне true, ако текста има смисъл ще върне false
        {

        }
    }

    public static void Divide(int a)
    {
        if (a == 10)
        {
            //throw new IndexOutOfRangeException();
            throw new FormatException("Format is not valid!");
            //по някаква причина, ако а = 10 нека това да е грешка
            //System.ArgumentException-ако аргумента, който е подаден на някаква функция не е адекватен
            //throw new ArgumentException("Ten is not allowed!");
        }
        int result = 10 / a;

    }
    public static void ReadNumber()
    {
        try
        {

            int a = int.Parse(Console.ReadLine());
            Divide(a);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Divide failed!");
            throw;
            //throw new IndexOutOfRangeException("Sory!", ex);
        }

    }

    public static void Method()
    {
        Method();
    }

    public static void Main()
	{
		//Method();//System.StackOverflowException

		
		try 
		{
			ReadNumber();
		}
		catch (DivideByZeroException ex)
		{
			
			//Environment.Exit(0);//гаси програмата, решение за излизане от рекурсия
		}
		catch (ArgumentException ex)
		{
			//Console.WriteLine("Error!");
			
			//Console.WriteLine("End of input reached!");//файл, който няма достатъчно редове
		}
		catch
		{
			//Console.WriteLine("Error!");//може да го използваме за всякакви грешки
		}
		catch (Exception)
		{
			Console.WriteLine("Program failed!");
			throw;
			//Console.WriteLine(ex.Message);
		}
		finally//независимо дали има някакъв exception, това ще се изпълни
		{
			//clear ram
			Console.WriteLine("Always!");
		}
		Console.WriteLine("Drugi neshta");
		 
	}
}