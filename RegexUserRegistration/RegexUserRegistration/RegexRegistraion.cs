using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    class RegexRegistraion
    {
        public static string FIRST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string LAST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string CONTACT_NUMBER = "^[0-9]{2} [6-9]{1}[0-9]{9}$";
        public static string EMAIL = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+.[a-z]{2,3}$";
        public static string PASSWORD = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[*.!@$%^&:;,.?_+-]){1}.{8,32}$";


        public bool ValidateFirstName()
        {
            return Regex.IsMatch("Pavan", FIRST_NAME);
        }
        public bool ValidateLastName()
        {
            return Regex.IsMatch("Rai", LAST_NAME);
        }
        public bool ValidateContactNumber()
        {
            return Regex.IsMatch("91 9863893536", CONTACT_NUMBER);
        }
        public bool ValidateEmail()
        {
            return Regex.IsMatch("bridgelabz123@gmail.com", EMAIL);
        }
        public bool ValidatePassword()
        {
            return Regex.IsMatch("#RsdR12345@", PASSWORD);
        }

    }
}
