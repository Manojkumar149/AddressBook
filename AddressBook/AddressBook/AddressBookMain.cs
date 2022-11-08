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
        public void EditContact(string name)
        {
            foreach(var contact in address)
            {
                Console.WriteLine(" Please Enter Below value to Edit Contact : \n 1.Address 2.City 3.State 4.ZipCode 5.PhoneNumber 6.EmailId");
                int option = Convert.ToInt32(Console.ReadLine());
                if(contact.FirstName.Equals(name) || contact.LastName.Equals(name))
                {
                    switch (option)
                    {
                        case 1:
                            contact.Address = Console.ReadLine(); 
                            break;
                        case 2:
                            contact.City = Console.ReadLine();
                            break;
                        case 3:
                            contact.State = Console.ReadLine();
                            break;
                        case 4:
                            contact.ZipCode = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 5:
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 6:
                            contact.EmailId = Console.ReadLine();
                            break;
                        default:
                            break;
                    }
                    Display();
                }
                
            }
        }
        public void DeleteContact(string name)
        {
            
            Contacts deleteContact = new Contacts();
            foreach (var contact in address)
            {
                if (contact.FirstName.Equals(name) || contact.LastName.Equals(name))
                {
                    deleteContact = contact;
                }
                
            }
            address.Remove(deleteContact);

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
