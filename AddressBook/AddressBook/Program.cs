namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Problem");
            Console.WriteLine(" 1. CreateContact \n 2. EditContact");
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
                        string name = Console.ReadLine();
                        addressBookMain.EditContact(name);
                        break;
                    default:
                        break;

                }
            }
        }
    }
}