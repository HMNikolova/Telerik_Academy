//7. Quotes in Strings

//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;

    class QuotesInStrings
    {
        static void Main()
        {
            string firstQuotes = "The \"use\" of quotations causes difficulties.";
            string secondQuotes = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(firstQuotes);
            Console.WriteLine(secondQuotes);
        }
    }

