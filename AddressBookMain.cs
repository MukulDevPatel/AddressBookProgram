using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        List<Contact> addressList = new List<Contact>();
        public  AddressBookMain()
        {
            Contact contact = new Contact()
            {
                FirstName = "Mukul",
                LastName = "Patel",
                Address = "Khopli",
                City = "Durg",
                State = "Chhattisgarh",
                Zip = "466565",
                PhoneNumber = "1234567890",
                Email = "mukulpatel@gmail.com",
            };
            addressList.Add(contact);
        }
        public void AddContact()
        {
            Contact contact = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Console.ReadLine(),
                PhoneNumber = Console.ReadLine(),
                Email = Console.ReadLine(),
            };
            addressList.Add(contact);
        }
    }
}
