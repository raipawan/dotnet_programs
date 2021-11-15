using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace AddressBook
{
    class AddressBook
    {
        Dictionary<string, Contact> ContactList;

        public AddressBook()
        {
            this.ContactList = new Dictionary<string, Contact>();
        }
        public bool AddContact(Contact contact)
        {
            string name = contact.firstName + " " + contact.lastName;
            if (!ContactList.ContainsKey(name))
            {
                ContactList.Add(name, contact);
                return true;
            }
            return false;
        }

        public bool RemoveContact(string name)
        {
            if (ContactList.ContainsKey(name))
            {
                ContactList.Remove(name);
                return true;
            }
            return false;
        }

        public Contact SearchContact(string name)
        {
            Contact contact = null;
            if (ContactList.ContainsKey(name))
            {
                contact = ContactList[name];
                Console.WriteLine("Contact name is :" + contact.firstName + " " + contact.lastName);
                Console.WriteLine("Contact mob No. is :" + contact.phoneNumber);
                Console.WriteLine("Contact email is :" + contact.email);
                Console.WriteLine("Contact address is :" + contact.GetAddress());
            }
            return contact;
        }

        public bool EditContact(Contact newContact)
        {
            string name = newContact.firstName + " " + newContact.lastName;
            if (ContactList.ContainsKey(name))
            {
                ContactList[name] = newContact;
                return true;
            }
            return false;

        }

        public string GetAddress(string name)
        {
            if (ContactList.ContainsKey(name))
            {
                Contact contact = null;
                string address = contact.city + " " + contact.state + " " + contact.pinCode;
                return address;
            }
            return null;
        }
    }
}
