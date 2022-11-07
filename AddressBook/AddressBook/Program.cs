namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Problem");
            Contacts contacts = new Contacts()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                ZipCode = Convert.ToInt64(Console.ReadLine()),
                PhoneNumber = Console.ReadLine(),
                EmailId = Console.ReadLine()
            };
            Console.WriteLine("Contact Details " + "\n" + contacts.FirstName + "\n" + contacts.LastName + "\n" + contacts.Address + "\n" +
                contacts.City + "\n" + contacts.State + "\n" + contacts.ZipCode + "\n" + contacts.PhoneNumber + "\n" + contacts.EmailId);
        }
    }
}