/*
|--------------------------------------------------------------------------
| Chapter 4. Console Input and Output
|--------------------------------------------------------------------------
|
| Exercise 3:
|
|     A given company has name, address, phone number,
|     fax number, web site and manager. The manager has
|     name, surname and phone number.
|
|     Write a program that reads information about the company
|     and its manager and then prints it on the console.
|
| Solutions and Guidelines:
|
|     Format the text with Write(...) or WriteLine(...) similar
|     to the example with the letter that we looked at.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the company information:");
            Console.Write("\nName: ");
            string companyName = Console.ReadLine();
            Console.Write("Address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone:");
            string companyPhone = Console.ReadLine();
            Console.Write("Fax number: ");
            string companyFaxNumber = Console.ReadLine();
            Console.Write("Web site: ");
            string companyWebSite = Console.ReadLine();
            Console.Write("Manager: ");
            string companyManager = Console.ReadLine();

            Console.WriteLine("\nEnter manager information:");
            Console.Write("\nName: ");
            string managerName = Console.ReadLine();
            Console.Write("Surname: ");
            string managerSurname = Console.ReadLine();
            Console.Write("Phone number:");
            string managerPhoneNumber = Console.ReadLine();

            Console.WriteLine("\nCompany info:" +
                "\nName: {0}" +
                "\nAddress: {1}" +
                "\nPhone: {2}" +
                "\nFax number: {3}" +
                "\nWeb site: {4}" +
                "\nManager: {5}", companyName, companyAddress, companyPhone,
                companyFaxNumber, companyWebSite, companyManager);

            Console.WriteLine("\nManager Info:" +
                "\nName: {0}" +
                "\nSurname: {1}" +
                "\nPhoneNumber: {2}", managerName, managerSurname, managerPhoneNumber);
        }
    }
}