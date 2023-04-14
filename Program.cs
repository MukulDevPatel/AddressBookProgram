using System;
namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System");
            AddressBookMain addressBook = new AddressBookMain();
            addressBook.AddContact();
        }
    }
}
