using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System");
            AddressBookMain addressBook = new AddressBookMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the option\n1. Add Contact\n2. Edit Contact\n3. Delete\n4 Exit.");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBook.AddContact();
                        break;
                    case 2:
                        addressBook.EditContact();
                        break;
                    case 3:
                        addressBook.Delete();
                        break;
                    case 4:
                        flag = false;
                        break;

                }
            }
        }
    }
}
