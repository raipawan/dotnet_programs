using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    class UC9
    {
        public static string EMAIL = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+.[a-z]{2,3}$";

        public bool ValidateEmail()
        {
            return Regex.IsMatch("abc@yahoo.com", EMAIL);
            return Regex.IsMatch("abc-100@yahoo.com", EMAIL);
            return Regex.IsMatch("abc.100@yahoo.com,", EMAIL);
            return Regex.IsMatch("abc111@abc.com", EMAIL);
            return Regex.IsMatch("abc-100@abc.net", EMAIL);
            return Regex.IsMatch("abc.100@abc.com.au", EMAIL);
            return Regex.IsMatch("abc@1.com", EMAIL);
            return Regex.IsMatch("abc@gmail.com.com", EMAIL);
            return Regex.IsMatch("abc+100@gmail.com", EMAIL);

        }
    }
}
