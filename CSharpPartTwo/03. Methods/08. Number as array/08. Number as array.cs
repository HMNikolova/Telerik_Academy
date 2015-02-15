using System;

class NumberAsArray
{
    
    
        //•	Write a method that adds two positive integer numbers represented as arrays of digits 
        //  (each array element arr[i]contains a digit; the last digit is kept in arr[0]).
        //•	Each of the numbers that will be added could have up to 10 000 digits.

    static uint[] SumArrays(uint[] n1, uint[] n2)
    {
        uint[] l = new uint[n1.Length + 1];
        uint sum = 0;
        uint next = 0;

        for (int i = 0; i < n1.Length; i++)
        {
            sum = n1[i] + n2[i];
            l[i] = (sum % 10) + next;

            if (sum < 10)
            {
                next = 0;
            }
            else
            {
                next = 1;
            }
        }

        if (next == 1) l[n1.Length] = 1;

        return l;
    }

    static void Main()
    {
        uint[] a = { 9, 9, 9 };
        uint[] b = { 1, 1, 1 };
        string res = "";
        uint[] result = SumArrays(a, b);

        for (int i = result.Length - 1; i >= 0; i--)
        {
            res += result[i];
        }

        Console.WriteLine("Sum is " + res);
    }
    }


