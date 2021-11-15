using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            AddressBook addressBook = new AddressBook();
            do
            {
                Console.WriteLine("Please choose an option");
                Console.WriteLine("Enter 1 to add a new contact");
                Console.WriteLine("Enter 2 to delete an existing contact");
                Console.WriteLine("Enter 3 to find/Search a contact");
                Console.WriteLine("Enter 4 to modify/edit the contact");
                Console.WriteLine("Enter 5 to exit");
                input = Console.ReadLine().Trim();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Please provide contact details in the following pattern");
                        Console.WriteLine("FirstName LastName City State Pincode MobileNumber Email");
                        string[] contactDetails = Console.ReadLine().Trim().Split(" ");
                        Contact contact = addressBook.SearchContact(contactDetails[0] + " " + contactDetails[1]);
                        if (contact == null)
                        {
                            contact = new Contact(contactDetails[0], contactDetails[1], contactDetails[2], contactDetails[3], contactDetails[4], contactDetails[5], contactDetails[6]);
                            bool addResult = addressBook.AddContact(contact);
                            if (addResult)
                                Console.WriteLine("Contact added successfully");
                            else
                                Console.WriteLine("Failed to add contact");
                        }
                        else
                            Console.WriteLine("Contact for " + contactDetails[0] + " " + contactDetails[1] + " already present");
                        break;
                    case "2":
                        Console.WriteLine("Enter full name of the person whose contact need to be deleted i.e. Pavan Rai");
                        string name = Console.ReadLine().Trim();
                        bool result = addressBook.RemoveContact(name);
                        if (result)
                            Console.WriteLine("Contact removed successfully");
                        else
                            Console.WriteLine("Contact not found for " + name);
                        break;
                    case "3":
                        Console.WriteLine("Enter full name of the person whose contact you want i.e. Pavan Rai");
                        name = Console.ReadLine().Trim();
                        contact = addressBook.SearchContact(name);
                        if (contact == null)
                            Console.WriteLine("Contact not found for " + name);
                        break;
                    case "4":
                        Console.WriteLine("Enter full name of the person whose contact you want to modify i.e. Pavan Rai");
                        name = Console.ReadLine().Trim();
                        contact = addressBook.SearchContact(name);
                        Console.WriteLine("what do you want to modify");
                        if (contact == null)
                            Console.WriteLine("Contact not found for " + name);
                        break;


                        break;
                }

            }
            while (input.CompareTo("5") != 0);
            /*Person person = new Person();
            person.firstName = "ram";

            Random random = new Random();
            int n = random.Next(0, 4);

            switch (n)
            {
                case 0:
                    AddressBook addressBook = new AddressBook();
                    addressBook.AddContact(contact);
                    break;
                case 1:
                    AddressBook addressBook1 = new AddressBook();
                    addressBook1.EditContact();
                    break;
            }*/
        }
    }
}
