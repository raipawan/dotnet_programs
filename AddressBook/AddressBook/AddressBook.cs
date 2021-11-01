using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace AddressBook
{
    class AddressBook
    {
        Hashtable ContactList;

        public AddressBook()
        {
            this.ContactList = new Hashtable();
        }
        public void AddContact()
        {
            Contact contact = new Contact();

            Console.WriteLine("enter first name");
            contact.firstName = Console.ReadLine();

            Console.WriteLine("enterlast name");
            contact.lastName = Console.ReadLine();

            Console.WriteLine("enter address");
            contact.address = Console.ReadLine();




        }

    }
}
