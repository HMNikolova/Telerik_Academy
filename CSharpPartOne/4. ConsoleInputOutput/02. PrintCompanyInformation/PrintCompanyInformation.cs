//2. Print Company Information
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Enter company name: ");
            string name = Console.ReadLine();

            Console.Write("Enter company address: ");
            string address = Console.ReadLine();

            Console.Write("Enter company number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter company fax number: ");
            int fax = int.Parse(Console.ReadLine());

            Console.Write("Enter company web site: ");
            string site = Console.ReadLine();

            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();

            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();

            Console.Write("Manager age: ");
            byte managerAge = byte.Parse(Console.ReadLine());

            Console.Write("Manager phone: ");
            int managerPhone = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}", name, address, number, fax, site);
            string fLName = managerFirstName + " " + managerLastName;
            Console.WriteLine("Manager: fLName (age: {0}, tel. {1})", managerAge, managerPhone);
        }
    }

