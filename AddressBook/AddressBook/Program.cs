﻿namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Problem");
            AddressBookMain addressBookMain = new AddressBookMain();
            addressBookMain.CreateContact();   
        }
    }
}