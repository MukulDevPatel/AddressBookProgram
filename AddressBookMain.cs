using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public void EditContact(string name)
        {
            
        }

        public void EditContact()
        {
            Console.WriteLine("Edit using First name");
            string name = Console.ReadLine();
            foreach (var data in addressList)
            {
                if (data.FirstName == name)
                {
                    Console.WriteLine("Enter option to edit\n1. First Name\n2. Last Name\n3. Address\n4. City\n5. State\n6. ZIP\n7. Phone Number\n8. Email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            data.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            data.LastName = Console.ReadLine();
                            break;
                        case 3:
                            data.Address = Console.ReadLine();
                            break;
                        case 4:
                            data.City = Console.ReadLine();
                            break;
                        case 5:
                            data.State = Console.ReadLine();
                            break;
                        case 6:
                            data.Zip = Console.ReadLine();
                            break;
                        case 7:
                            data.PhoneNumber = Console.ReadLine();
                            break;
                        case 8:
                            data.Email = Console.ReadLine();
                            break;
                    }
                }
            }
        }
    }
}
