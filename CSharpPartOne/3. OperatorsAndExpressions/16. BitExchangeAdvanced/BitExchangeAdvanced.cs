//16.** Bit Exchange (Advanced)
//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.

using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("n = ");
        long n = long.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("q = ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

        if (p + k >= 32)
        {
            Console.WriteLine("Out of range");
        }
        else if (p < q && ((p + q) < k))
        {
            Console.WriteLine("Overlapping");
        }
        else
        {
            for (int i = 0; i < k; i++)
            {
                int firstMask = (int)(n & (1 << p)) >> p;
                int secondMask = (int)(n & (1 << q)) >> q;

                if (firstMask == 0)
                {
                    n = n & (~(1 << q));
                }
                else if (firstMask == 1)
                {
                    n = n | (1 << q);
                }

                if (secondMask == 0)
                {
                    n = n & (~(1 << p));
                }
                else if (secondMask == 1)
                {
                    n = n | (1 << p);
                }

                p++;
                q++;
            }

            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine(n);
        }
    }

}