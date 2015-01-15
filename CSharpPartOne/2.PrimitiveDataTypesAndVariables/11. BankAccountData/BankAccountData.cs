//11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Hristina";
            string middleName = "Marinova";
            string lastName = "Nikolova";
            decimal balance = 1234.12M;
            string bankName = "Bank";
            string iban = "BG12SF1265894523546523";
            ulong firstCreditCard = 354562102385;
            ulong secondCreditCard = 956235620145;
            ulong thirdCreditCard = 456235689451;

            Console.WriteLine("Bank account holder: {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine("Balance holder: {0}lv.", balance);
            Console.WriteLine("Bank name: {0}", bankName);
            Console.WriteLine("IBAN {0}", iban);
            Console.WriteLine("Credit cards: {0}, {1}, {2}", firstCreditCard, secondCreditCard, thirdCreditCard);
        }
    }

