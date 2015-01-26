using System;

    class CartesianCoordinateSystem
    {
        static void Main()
        {
            string stringX = Console.ReadLine();
            double coordinateX = double.Parse(stringX);
            string stringY = Console.ReadLine();
            double coordinateY = double.Parse(stringY);
            int result = 0;
            if (coordinateX == 0 && coordinateY == 0)
            {
                result = 0;
            }
            else if (coordinateX > 0 && coordinateY > 0)
            {
                result = 1;
            }
            else if (coordinateX < 0 && coordinateY > 0)
            {
                result = 2;
            }
            else if (coordinateX < 0 && coordinateY < 0)
            {
                result = 3;
            }
            else if (coordinateX > 0 && coordinateY < 0)
            {
                result = 4;
            }
            else if (coordinateX == 0)
            {
                result = 5;
            }
            else
            {
                result = 6;
            }
            Console.WriteLine(result);
        }
    }

