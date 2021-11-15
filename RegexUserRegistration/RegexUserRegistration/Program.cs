using System;

namespace RegexUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexRegistraion regexRegistraion = new RegexRegistraion();
            bool firstName = regexRegistraion.ValidateFirstName();
            bool lastName = regexRegistraion.ValidateLastName();
            bool contactNumber = regexRegistraion.ValidateContactNumber();
            bool Email = regexRegistraion.ValidateEmail();
            bool Password = regexRegistraion.ValidatePassword();

            Console.WriteLine("firstName" + " " + firstName);
            Console.WriteLine("lastName" + " " + lastName);
            Console.WriteLine("contactNumber" + " " + contactNumber);
            Console.WriteLine("Email" + " " + Email);
            Console.WriteLine("Password" + " " + Password);

            /* UC9 uC9 = new UC9();
             bool Email = uC9.ValidateEmail();
             Console.WriteLine("email1" + " " + Email);
             Console.WriteLine("email2" + " " + Email);
             Console.WriteLine("email3" + " " + Email);
             Console.WriteLine("email4" + " " + Email);
             Console.WriteLine("email5" + " " + Email);
             Console.WriteLine("email6" + " " + Email);
             Console.WriteLine("email7" + " " + Email);
             Console.WriteLine("email8" + " " + Email);*/
        }
    }
}
