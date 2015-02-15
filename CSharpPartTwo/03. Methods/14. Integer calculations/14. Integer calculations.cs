using System;
using System.Linq;
using System.Numerics;

class IntegerCalculations
{
        //•	Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
        //•	Use variable number of arguments.
         static void Main()
    {
        Random randomGenerator = new Random();
            int[] array = FillArray(randomGenerator);

            PrintArray(array);
            Console.WriteLine();

            Console.WriteLine("The minimal value is : {0}", MinimumValue(array));
            Console.WriteLine("The maximal value is : {0}", MaximumValue(array));
            Console.WriteLine("The average value is : {0}", AverageValue(array));
            Console.WriteLine("The sum is : {0}", Sum(array));
            Console.WriteLine("The product is : {0}", Product(array));
        }


        private static int MinimumValue(int[] array)
        {
            Array.Sort(array);

            return array[0];
        }

        private static int MaximumValue(int[] array)
        {
            Array.Sort(array);

            return array[array.Length - 1];
        }

        private static double AverageValue(int[] array)
        {
            return array.Average();
        }

        private static long Sum(int[] array)
        {
            long sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        private static BigInteger Product(int[] array)
        {
            BigInteger product = 1;

            for (int i = 0; i < array.Length; i++)
            {
                product *= (BigInteger)array[i];
            }

            return product;
        }

        private static int[] FillArray(Random randomGenerator)
        {
            int length = int.MinValue;
            do
            {
                length = GetNumber("the length of the array (1 - 99)");
            }
            while (length < 1 || length > 99);

            int[] array = new int[length];

            for (int index = 0; index < array.Length; index++)
            {
                array[index] = randomGenerator.Next(1, 100);
            }

            return array;
        }

        private static void PrintArray(int[] array)
        {
            string result = string.Join(", ", array);

            Console.WriteLine("{ " + result + " }");
        }

        private static int GetNumber(string name)
        {
            int number = int.MinValue;
            bool isNumber = false;

            do
            {
                Console.Write("Please, enter {0}: ", name);
                isNumber = int.TryParse(Console.ReadLine(), out number);
            }
            while (isNumber == false);

            return number;
        }
    }
    


