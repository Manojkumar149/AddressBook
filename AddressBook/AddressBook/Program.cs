namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Problem");
            Console.WriteLine(" 1. CreateContact \n 2. EditContact \n 3. DeleteContact");
            AddressBookMain addressBookMain = new AddressBookMain();
            int option = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                switch (option)
                {
                    case 1:
                        addressBookMain.CreateContact();
                        break;
                    case 2:
                        Console.WriteLine(" Please Enter FirstName or LastName to EditContact");
                        string editContact = Console.ReadLine();
                        addressBookMain.EditContact(editContact);
                        break;
                    case 3:
                        Console.WriteLine("Please Enter FirstName or LastName to DeleteContact");
                        string deleteContact = Console.ReadLine();
                        addressBookMain.DeleteContact(deleteContact);
                        break;
                    default:
                        break;

                }
                break;
            }
        }
    }
}