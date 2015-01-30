//12.* Randomize the Numbers 1…N
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;

    class RandomizeTheNumbers1N
    {
        static void Main()
        {
            Console.WriteLine("Randomize The Numbers from 1 To N");
            Console.Write("Enter an number n = ");
            int nums = 0;
            int num = int.Parse(Console.ReadLine());
            int[] numbers = new int[num];
            
           
            for (int i = 0; i < num; i++)
            {
               
                nums++;
                
                numbers[i] = nums;
                
            }
            MixArray(numbers);
            foreach (int item in numbers)
            {
                Console.Write("{0} ",item);
            }
            
           
            Console.WriteLine();
        }
        public static void MixArray(int[] array)
        {
            int index, temp;

            Random randomGenerator = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                index = randomGenerator.Next(array.Length);

                temp = array[i];
                array[i] = array[index];
                array[index] = temp;
            }
        }
     }
    

