//9. Play with Int, Double and String
//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.


using System;

    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        Console.Write("Please write a number between 1 and 3: ");
        int type = int.Parse(Console.ReadLine());
            switch (type)
                {
                    case 1: Console.Write("Please enter a int: ");
                        int typeInt = int.Parse(Console.ReadLine());
                        Console.WriteLine(typeInt + 1);
                        break;
                    case 2: Console.Write("Please enter a double: ");
                        double typeDouble = double.Parse(Console.ReadLine());
                        Console.WriteLine(typeDouble + 1);
                        break;
                    case 3: Console.Write("Please enter a string: ");
                        string typeString = Console.ReadLine();
                        Console.WriteLine(typeString + '*');
                        break;
                    default: Console.WriteLine("This is not correct number!");
                        break;
        	    }
        }
    }

