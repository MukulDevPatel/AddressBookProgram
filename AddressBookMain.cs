using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contact> addressList = new List<Contact>();
        public void AddressBook()
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
    }
}
