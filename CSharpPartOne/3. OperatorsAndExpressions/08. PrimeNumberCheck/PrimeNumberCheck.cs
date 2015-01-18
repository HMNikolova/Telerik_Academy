//8. Prime Number Check
//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

using System;

    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Please enter positive integer number here to check if is prime:");
            int inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber < 2)
            {
                Console.WriteLine("The number is not prime!!!");
                return;
            }

            int devider = 2;
            int maxDevider = (int)Math.Sqrt(inputNumber);
            bool prime = true;

            while (prime && (devider <= maxDevider))
            {
                if (inputNumber % devider == 0)
                {
                    prime = false;
                    Console.WriteLine("The number is not prime because: {0}*{1}={2}",
                        devider, inputNumber / devider, inputNumber);
                }
                devider++;
            }
            Console.WriteLine("The number {0} is prime? -> {1}", inputNumber, prime);;
        }
    }

