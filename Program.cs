using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System");
            AddressBookMain addressBook = new AddressBookMain();
            addressBook.AddressBook();
        }
    }
}
