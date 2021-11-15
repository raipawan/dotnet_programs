using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Contact
    {
        public string firstName;
        public string lastName;
        public string city;
        public string state;
        public string pinCode;
        public string phoneNumber;
        public string email;

        public Contact(string firstName, string lastName, string city, string state, string pinCode, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
            this.state = state;
            this.pinCode = pinCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public string GetAddress()
        {
            string address = this.city + " " + this.state + " " + this.pinCode;
            return address;
        }
    }

}
