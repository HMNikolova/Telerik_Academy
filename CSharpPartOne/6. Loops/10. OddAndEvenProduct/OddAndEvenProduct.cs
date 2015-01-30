//10. Odd and Even Product
//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

    class OddAndEvenProduct
    {
        static void Main()
        {
             Console.WriteLine("Odd And Even Product");
            Console.Write("Enter a numbers in a single line separated with space: ");
            string[] input = Console.ReadLine().Split();
            int oddProduct = 1;
            int evenProdduct = 1;
            for (int index = 0; index < input.Length; index++)
            {
                int num = int.Parse(input[index]);
                if (index %2 == 0 || index == 0)
                {
                    oddProduct *= num;
                }
                else
                {
                    evenProdduct *= num;    
                }

            }
            if (oddProduct == evenProdduct)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", oddProduct);   
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd Product = {0}", oddProduct);
                Console.WriteLine("even Product = {0}", evenProdduct);    
            }
         

        }
  }
      
    

