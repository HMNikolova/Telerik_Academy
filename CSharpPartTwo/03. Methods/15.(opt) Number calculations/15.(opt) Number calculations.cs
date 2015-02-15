using System;

class NumberCalculations
{
    static void Main()
    {
        /*•	Modify your last program and try to make it work for any number type, not just integer 
         * (e.g. decimal, float, byte, etc.)
          •	Use generic method (read in Internet about generic methods in C#).*/
         decimal[] dc = new decimal[] { 6.1m, 3.11111m, 2.543m };
            float[] fl = new float[] { 6.1f, 3.1111f, 2.543f };
            byte[] bt = new byte[] { 6, 3, 2 };
            double[] db = new double[] { 26.1, 32.11111, 22.543 };
            long[] lg = new long[] { 872323726, 93345365352, 52545434352 };

            Calculate(dc);
            Calculate(fl);
            Calculate(bt);
            Calculate(db);
            Calculate(lg); 
        }


        private static T GetMinimumValue<T>(params T[] array) where T : IComparable<T>
        {
            Array.Sort(array);

            return (dynamic)array[0];
        }

        private static T GetMaximumValue<T>(params T[] array) where T : IComparable<T>
        {
            Array.Sort(array);

            return (dynamic)array[array.Length - 1];
        }

        private static double GetAverageValue<T>(params T[] array)
        {
            return Convert.ToDouble(GetSum(array)) / array.Length;
        }

        private static dynamic GetSum<T>(params T[] array)
        {
            dynamic sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        private static dynamic GetProduct<T>(params T[] array)
        {
            dynamic product = 1;

            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }

            return product;
        }

        private static void Calculate<T>(params T[] array)
        {
            dynamic arrForUse = array;

            var min = GetMinimumValue(arrForUse);
            var max = GetMaximumValue(arrForUse);
            var sum = GetSum(arrForUse);
            var average = GetAverageValue(arrForUse);
            var product = GetProduct(arrForUse);

            Console.WriteLine("The minimum is : {0}", min);
            Console.WriteLine("The maxmimum is : {0}", max);
            Console.WriteLine("The sum is : {0}", sum);
            Console.WriteLine("The average number is : {0}", average);
            Console.WriteLine("The product is : {0}", product);
            Console.WriteLine();
        }
    }


