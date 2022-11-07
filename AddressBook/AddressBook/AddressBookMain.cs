using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contacts> address = new List<Contacts>();
        public void CreateContact()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter First Name :");
            contacts.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            contacts.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address :");
            contacts.Address = Console.ReadLine();
            Console.WriteLine("Enter City :");
            contacts.City = Console.ReadLine();
            Console.WriteLine("Enter State :");
            contacts.State = Console.ReadLine();
            Console.WriteLine("Enter Zip :");
            contacts.ZipCode = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Phone Number :");
            contacts.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email :");
            contacts.EmailId = Console.ReadLine();
            address.Add(contacts);
            Display();
        }
        public void Display()
        {
            foreach (var contacts in address) {
                Console.WriteLine("\nContact Details " + "\n" + contacts.FirstName + "\n" + contacts.LastName + "\n" + contacts.Address + "\n" +
                        contacts.City + "\n" + contacts.State + "\n" + contacts.ZipCode + "\n" + contacts.PhoneNumber + "\n" + contacts.EmailId);
            }
        }
    }
}
